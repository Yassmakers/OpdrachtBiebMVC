    using BiebWebApp.Data;
    using BiebWebApp.Models;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;

//Namespace for the controllers in the application.
namespace BiebWebApp.Controllers
    {
    //The HomeController handles actions related to the home page and profile management.
    public class HomeController : Controller
        {
        //These are private readonly fields used throughout the class.
        private readonly BiebWebAppContext _context;
            private readonly UserManager<User> _userManager;
            private readonly SignInManager<User> _signInManager;
            private readonly ILogger<HomeController> _logger;
            private readonly RoleManager<IdentityRole<int>> _roleManager;

        //Constructor for HomeController, setting up context, user and role managers, and logger.
        public HomeController(BiebWebAppContext context, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<HomeController> logger, RoleManager<IdentityRole<int>> roleManager)
            {
                _context = context;
                _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
                _signInManager = signInManager;
                _logger = logger;
                _roleManager = roleManager;
            }

        //Http GET action for retrieving user's profile.

        [HttpGet("profile")]
            public IActionResult Profile()
            {
            //Get user's ID.
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Find the user with this ID.
            var user = _userManager.FindByIdAsync(userId).Result;

            //If user is not found, return NotFound result.
            if (user == null)
                {
                    return NotFound();
                }

            //If user is blocked, log them out.
            if (user.IsBlocked)
                {
                    return RedirectToAction(nameof(Logout));
                }

            //Retrieve all reservations made by the user.
            var reservations = _context.Reservations
                    .Include(r => r.User)
                    .Include(r => r.Item)
                    .Include(r => r.Loans)
                    .ThenInclude(l => l.Item)
                    .Where(r => r.UserId == user.Id)
                    .ToList();

            //Retrieve all loans that are overdue for the user.
            var loans = _context.Loans
                    .Include(l => l.User)
                    .Include(l => l.Item)
                    .Where(l => l.UserId == user.Id && l.ReturnDate < DateTime.Now)
                    .ToList();
           
            //Determines if user has a subscription.
            var hasSubscription = user.HasSubscription;
                var subscriptionType = GetSubscriptionTypeName(user.SubscriptionType); // Get the subscription type name

                var reservationFine = GetReservationFine(user.SubscriptionType);
                var reservationCharge = GetReservationCharge(user.SubscriptionType);
                _logger.LogInformation($"Reservation Fine: {reservationFine}, Reservation Charge: {reservationCharge}");

                var subscriptionCharge = GetSubscriptionCharge(user.SubscriptionType);
                _logger.LogInformation($"Subscription Charge: {subscriptionCharge}");

                var totalReservationCharge = reservations.Count * reservationCharge; // Calculate the total reservation charge

            //Create and populate ViewModel for the Profile view.
            var model = new ProfileViewModel
                {
                    User = user,
                    Reservations = reservations ?? new List<Reservation>(),
                    Loans = loans ?? new List<Loan>(),
                    HasSubscription = hasSubscription,
                    SubscriptionType = subscriptionType, // Set the subscription type property
                    ReservationFine = reservationFine, // Set the reservation fine property
                    ReservationCharge = reservationCharge, // Set the reservation charge property
                    SubscriptionCharge = subscriptionCharge,
                    TotalReservationCharge = totalReservationCharge, // Set the total reservation charge property
                            HasPaid = user.HasPaid // Set the HasPaid property
                };

                ViewBag.HasSubscription = hasSubscription;

            //Return the Profile view populated with the model.
            return View(model);
            }



        //These helper methods determine subscription details based on subscription type.
        public string GetSubscriptionTypeName(string subscriptionType)
            {
                switch (subscriptionType)
                {
                    case "1":
                        return "Youth Subscription";
                    case "2":
                        return "Budget Subscription";
                    case "3":
                        return "Basic Subscription";
                    case "4":
                        return "Top Subscription";
                    default:
                        return "No Subscription";
                }
            }


            private decimal GetSubscriptionCharge(string subscriptionType)
            {
                if (int.TryParse(subscriptionType, out int type))
                {
                    switch (type)
                    {
                        case 1:
                            return 0.00m;
                        case 2:
                            return 1.00m;
                        case 3:
                            return 4.00m;
                        case 4:
                            return 6.00m;
                        default:
                            return 0.00m;
                    }
                }

                return 0.00m;
            }

            private decimal GetReservationFine(string subscriptionType)
            {
                if (int.TryParse(subscriptionType, out int type))
                {
                    switch (type)
                    {
                        case 1:
                            return 0.25m;
                        case 2:
                        case 3:
                        case 4:
                            return 0.30m;
                        default:
                            return 0.00m;
                    }
                }

                return 0.00m;
            }

            private decimal GetReservationCharge(string subscriptionType)
            {
                if (int.TryParse(subscriptionType, out int type))
                {
                    switch (type)
                    {
                        case 1:
                            return 0.25m;
                        case 2:
                            return .25m;
                        case 3:
                            return 0.25m;
                        case 4:
                            return 0.00m;
                        default:
                            return 0.00m;
                    }
                }

                return 0.00m;
            }








        //Http GET action for the home page.
        public IActionResult Index(string searchString, string filter, string author, int? year, string location, int? yearFilter)
        {
            //If the user is accessing the Loans page, return an empty view.
            if (HttpContext.Request.Path == "/loans")
            {
                // If the user is accessing the Loans page, return the view without updating item statuses
                return View(new List<Item>());
            }

            //Create query to select all items.
            IQueryable<Item> itemsQuery = _context.Items.Include(i => i.Reservations);

            //Filter items based on searchString, filter, author, year, and location.
            if (!string.IsNullOrEmpty(searchString))
            {
                string searchStringUpper = searchString.ToUpper();
                itemsQuery = itemsQuery.Where(item =>
                    EF.Functions.Like(item.Title.ToUpper(), $"%{searchStringUpper}%") ||
                    EF.Functions.Like(item.Author.ToUpper(), $"%{searchStringUpper}%") ||
                    EF.Functions.Like(item.Location.ToUpper(), $"%{searchStringUpper}%"));
            }

            if (!string.IsNullOrEmpty(filter))
            {
                ItemType itemType;
                if (Enum.TryParse(filter, out itemType))
                {
                    itemsQuery = itemsQuery.Where(item => item.ItemType == itemType);
                }
            }

            if (!string.IsNullOrEmpty(author))
            {
                itemsQuery = itemsQuery.Where(item =>
                    item.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (year.HasValue)
            {
                itemsQuery = itemsQuery.Where(item => item.Year == year);
            }

            if (yearFilter.HasValue)
            {
                itemsQuery = itemsQuery.Where(item => item.Year.ToString() == yearFilter.Value.ToString());
            }

            if (!string.IsNullOrEmpty(location))
            {
                itemsQuery = itemsQuery.Where(item =>
                    item.Location.IndexOf(location, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var items = itemsQuery.ToList();

            //Update the status of each item based on whether they are reserved or loaned.
            foreach (var item in items)
                {
                    var reservation = _context.Reservations.FirstOrDefault(r => r.ItemId == item.Id);

                    if (reservation != null)
                    {
                        item.Status = ItemStatus.Reserved; // Update the status of the item to 'Reserved'
                    }
                    else
                    {
                        item.Status = ItemStatus.Available; // Update the status of the item to 'Available'
                    }

                    var loan = _context.Loans.FirstOrDefault(l => l.ItemId == item.Id && l.ReturnDate >= DateTime.Now);

                    if (loan != null)
                    {
                        item.Status = ItemStatus.Loaned; // Update the status of the item to 'Loaned'
                    }
                }

            //Save the status updates to the database.
            _context.SaveChanges();

            //Set initial value of ViewBag.HasSubscription to false.
            ViewBag.HasSubscription = false; 
                ViewBag.UserManager = _userManager;

            //If the user is logged in, update ViewBag.HasSubscription to reflect their subscription status.   
            if (User.Identity.IsAuthenticated)
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var user = _userManager.FindByIdAsync(userId).Result;

                    if (user != null)
                    {
                        ViewBag.HasSubscription = user.HasSubscription; // Set the value of HasSubscription based on the user's subscription status
                    }
                }
            //Return the Index view populated with the items.
            return View(items);
            }












        //Authorize attribute ensures that only logged-in users can reserve an item.
        [Authorize]
            public IActionResult Reserve(int? id)
            {
            //Null id check.
            if (id == null)
                {
                    return NotFound();
                }

            //Find item based on id.
            var item = _context.Items.FirstOrDefault(i => i.Id == id);

            //Null item check.
            if (item == null)
                {
                    return NotFound();
                }

            //Get current user's ID and find the user.
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _userManager.FindByIdAsync(userId).Result;

            //Null user check.
            if (user == null)
                {
                    return NotFound();
                }

                // Check if the user has already reserved the item
                var existingReservation = _context.Reservations.FirstOrDefault(r => r.ItemId == item.Id && r.UserId == user.Id);
                if (existingReservation != null)
                {
                    TempData["Message"] = "You have already reserved this item.";
                    return RedirectToAction(nameof(Profile));
                }

                // Check if the item is already reserved
                var reservedItem = _context.Reservations.FirstOrDefault(r => r.ItemId == item.Id);
                if (reservedItem != null)
                {
                    TempData["Message"] = "This item is already reserved.";
                    return RedirectToAction(nameof(Index));
                }

            //Create new reservation for the user.
            var reservation = new Reservation
                {
                    UserId = user.Id,
                    ItemId = item.Id,
                    ReservationDate = DateTime.Now
                };

                // Update the status of the item to 'Reserved'
                item.Status = ItemStatus.Reserved;

                _context.Reservations.Add(reservation);

                try
            {        //Save changes to the context to create the reservation.
                _context.SaveChanges(); 
                    _logger.LogInformation($"Reservation with ID {reservation.Id} created successfully.");
                }
                catch (Exception e)
                {
                    _logger.LogError($"Exception occurred while saving reservation: {e}");
                    return View("Error");
                }

                TempData["Message"] = "Reservation created successfully.";

                return RedirectToAction(nameof(Profile));
            }


        //Authorize attribute ensures that only logged-in users can delete a reservation.
        [Authorize]
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult DeleteReservation(int? id)
            {
            //Null id check.
            if (id == null)
                {
                    return NotFound();
                }

            //Find reservation based on id.
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);

                if (reservation == null)
                {
                    return NotFound();
                }

            //Remove reservation from the context.
            _context.Reservations.Remove(reservation);
            //Save changes to the context to delete the reservation.
            _context.SaveChanges();

                TempData["Message"] = "Reservation deleted successfully.";

                return RedirectToAction(nameof(Profile));
            }


        //Http GET action to display a user's profile based on id.
        [HttpGet("profile/{id}")]
            public async Task<IActionResult> Profile(int id)
            {
            //Find user based on id, including their reservations and loans.
            var user = await _context.Users
                    .Include(u => u.Reservations)
                        .ThenInclude(r => r.Loans)
                    .FirstOrDefaultAsync(u => u.Id == id);

            //Null user check.
            if (user == null)
                {
                    return NotFound();
                }

            //Create and populate ViewModel for the Profile view.
            var viewModel = new ProfileViewModel
                {
                    User = user,
                    Reservations = user.Reservations.ToList()
                };

            //Return the Profile view populated with the ViewModel.
            return View(viewModel);
            }


        //Authorize attribute ensures that only logged-in users can view details of a reservation.
        [Authorize]
            public IActionResult Details(int? id)
            {
            //Null id check.
            if (id == null)
                {
                    return NotFound();
                }

            //Find reservation based on id, including the user and item related to it.
            var reservation = _context.Reservations
                    .Include(r => r.User)
                    .Include(r => r.Item)
                    .FirstOrDefault(r => r.Id == id);

            //Null reservation check.
            if (reservation == null)
                {
                    return NotFound();
                }

            //Return the Details view populated with the reservation.
            return View(reservation);
            }


        //Http GET action for the login page.
        [HttpGet]
            public IActionResult Login()
            {
                // Here, i've chosen to use my own custom login logic instead of the default 
                // 'Individual accounts' option that was originally recommended. i chose this
                // route to have more control over the login process, especially considering
                // the potential to add custom security measures or other functionality not 
                // available in the pre-built login process. By leveraging the Identity library's
                // user manager, im still maintaining secure practices for authentication.

                return View();
            }

        //Http GET action for the registration page.
        public IActionResult Register()
            {
                // Similar to the login, i've implemented a custom registration process instead 
                // of the automatic one provided by the 'Individual accounts' option. This allows 
                // us to control the user creation process more granularly, and easily extend it 
                // in the future as needed.
                return View();
            }

        //Http POST action to handle the registration process.
        [HttpPost]
            public async Task<IActionResult> Register(RegisterModel model)
            {
            // This method handles the registration process. I use the User Manager from 
            // the Identity library to create a new user. By implementing the registration 
            // process ourselves, i gain the ability to add extra steps or checks that are 
            // specific to our application. My choice to implement a custom registration 
            // process is based on the requirements of the project and is not a decision made 
            // out of convenience. 

            //Model validation check.
            if (ModelState.IsValid)
                {
                //Create new user with provided details.
                User user = new User { UserName = model.Email, Name = model.Name, Email = model.Email, Type = model.Type };
                    IdentityResult result;

                try
                {
                    //Attempt to create the user.
                    result = await _userManager.CreateAsync(user, model.Password);
                    if (result == null)
                    {
                        _logger.LogError("User creation result is null.");
                        ModelState.AddModelError("", "User creation failed.");
                        return View(model);
                    }
                }
                catch (DbUpdateException ex)
                {
                    //Log error and return view with model if there was an exception.
                    _logger.LogError(ex, $"An error occurred while creating the user. Failed entities: {string.Join(", ", ex.Entries.Select(e => e.Entity.GetType().Name))}");

                    if (ex.InnerException != null)
                    {
                        _logger.LogError(ex.InnerException, $"Inner exception details:");
                    }

                    ModelState.AddModelError("", "An error occurred while creating the user.");
                    return View(model);
                }

                //If user creation succeeded, assign them a role and sign them in. Otherwise, add errors to the model state.
                if (result.Succeeded)
                    {
                        TempData["Message"] = "User created successfully.";

                        // Check if the role exists, and if not, create it
                        string roleName = UserType.Member.ToString();
                        if (!await _roleManager.RoleExistsAsync(roleName))
                        {
                            await _roleManager.CreateAsync(new IdentityRole<int>(roleName));
                        }

                        var roleResult = await _userManager.AddToRoleAsync(user, roleName);
                        if (!roleResult.Succeeded)
                        {
                            // Handle role assignment failure
                            _logger.LogError($"Failed to assign role '{roleName}' to user '{user.UserName}'. Errors: {string.Join(", ", roleResult.Errors)}");
                        }

                        // Sign in the user now
                        await _signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }
                }

            //Add model errors to model state and return view with model.
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    ModelState.AddModelError("", error.ErrorMessage);
                }

                return View(model);
            }

        // Http POST action to handle the login process

        [HttpPost]
            public async Task<IActionResult> Login(LoginModel model)
            {
            // This method handles the login process. The User Manager from the Identity 
            // library is used to find the user and validate their credentials. 
            // This custom approach allows us to add additional checks or modifications as 
            // needed, enhancing the flexibility of our application.
            // I fully understand this diverges from the original assignment requirements, 
            // but i do believe this approach provides a more adaptable solution to manage 
            // user authentication while maintaining security standards.

            // Model validation check
            if (ModelState.IsValid)
                {
                    _logger.LogInformation($"Attempting to find user with email {model.Email}.");
                // Find the user with the email provided
                var user = await _userManager.FindByEmailAsync(model.Email);
                    if (user != null)
                    {
                        _logger.LogInformation($"User {user.UserName} found. Attempting to sign in.");
                    // Try to sign in the user
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                        if (result.Succeeded)
                        {
                            _logger.LogInformation($"User {user.UserName} successfully logged in.");
                        // User signed in successfully, redirect to Home
                        return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            _logger.LogWarning($"Failed to log in user {user.UserName}. Sign-in result: {result}");
                        // Login attempt failed, show error
                        ModelState.AddModelError("", "Invalid login attempt.");
                            return View(model);
                        }
                    }
                    else
                    {
                        _logger.LogWarning($"Failed to find user with email {model.Email}.");
                    // User not found, show error
                    ModelState.AddModelError("", "Invalid login attempt.");
                    // Model state invalid, return same view
                    return View(model);
                    }
                }

                return View(model);
            }

        // Action to handle user logout
        public async Task<IActionResult> Logout()
            {
            // Sign out the current user
            await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }

        // Authorize attribute ensures that only logged-in users can create a loan
        [Authorize]
        public IActionResult Loan(int? id)
        {
            // Null id check
            if (id == null)
            {
                return NotFound();
            }

            // Find the current user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            if (user == null)
            {
                return NotFound();
            }

            // Find the reservation the user wants to loan
            var reservation = _context.Reservations
                .Include(r => r.Item)
                .FirstOrDefault(r => r.Id == id && r.UserId == user.Id);

            // Null reservation check
            if (reservation == null)
            {
                return NotFound();
            }

            var item = reservation.Item;

            // Check if the item is already loaned
            if (item.Status == ItemStatus.Loaned)
            {
                TempData["Message"] = "This item is already loaned.";
                return RedirectToAction(nameof(Profile));
            }

            var loans = _context.Loans
                .Where(l => l.UserId == user.Id && l.ReturnDate >= DateTime.Now)
                .ToList();

            var subscriptionType = user.SubscriptionType;
            var maxLoanLimit = GetMaxLoanLimit(subscriptionType);

            // Check if the user has reached the loan limit for loaning items at once
            if (loans.Count >= maxLoanLimit && subscriptionType != "4") // Exclude the top subscription
            {
                TempData["Message"] = $"You have reached your subscription's loan limit for loaning items at once ({maxLoanLimit} loans).";
                return RedirectToAction(nameof(Profile));
            }

            if (ExceedsLoanLimit(user, maxLoanLimit))
            {
                TempData["Message"] = $"You have reached your subscription's loan limit for loaning items at once ({maxLoanLimit} loans).";
                return RedirectToAction(nameof(Profile));
            }

            // Create a new loan
            var loan = new Loan
            {
                UserId = user.Id,
                ItemId = item.Id,
                ReservationId = reservation.Id,
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(21)
            };

            _logger.LogInformation($"Trying to create loan: {loan}");
            // Add the new loan to the context
            _context.Loans.Add(loan);

            try
            {
                // Update the status of the item to 'Loaned'
                item.Status = ItemStatus.Loaned;

                _context.SaveChanges();
                _logger.LogInformation($"Loan with ID {loan.Id} created successfully.");
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception occurred while saving loan: {e}");
                return View("Error");
            }

            TempData["Message"] = "Loan created successfully.";

            return RedirectToAction(nameof(Profile));
        }


        // Helper method to check if user has exceeded their loan limit
        private bool ExceedsLoanLimit(User user, int maxLoanLimit)
        {
            // Query database for active loans of the user
            var loans = _context.Loans
                .Where(l => l.UserId == user.Id && l.ReturnDate >= DateTime.Now)
                .ToList();

            // Check if the number of active loans is greater than or equal to max loan limit
            return loans.Count >= maxLoanLimit;
        }

        // Helper method to determine the max loan limit based on user's subscription type
        private int GetMaxLoanLimit(string subscriptionType)
        {
            if (int.TryParse(subscriptionType, out int type))
            {
                switch (type)
                {
                    // For subscription types 1, 2 and 3, loan limit is 10
                    case 1: // Youth Subscription
                    case 2: // Budget Subscription
                    case 3: // Basic Subscription
                        return 10; // Loan limit is 10
                    case 4: // Top Subscription
                        return 20; // Loan limit is 20
                    default:
                        return 0;
                }
            }
            // If subscription type is not recognized, return 0 as loan limit
            return 0;
        }







        // Action to handle subscription process *extra

        [Authorize]
            [HttpGet, HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Subscribe()
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _userManager.FindByIdAsync(userId).Result;

                if (user == null)
                {
                    return NotFound();
                }

                user.HasSubscription = true; // Set the subscription status to true
                _context.SaveChanges();

                TempData["Message"] = "Subscription created successfully.";

                return RedirectToAction(nameof(Profile));
            }





        // Action to handle the deletion of a reservation **Extra rm later
        [Authorize]
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
            // Find the reservation using id
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);

                if (reservation == null)
                {
                    return NotFound();
                }
            // Remove the reservation from the context
            _context.Reservations.Remove(reservation);
                _context.SaveChanges();

                TempData["Message"] = "Reservation deleted successfully.";

                return RedirectToAction(nameof(Profile));
            }
        }
    }