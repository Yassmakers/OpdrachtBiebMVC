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

namespace BiebWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BiebWebAppContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public HomeController(BiebWebAppContext context, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<HomeController> logger, RoleManager<IdentityRole<int>> roleManager)
        {
            _context = context;
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            }
        [HttpGet("profile")]
        public IActionResult Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            if (user == null)
            {
                return NotFound();
            }

            var reservations = _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .Include(r => r.Loans)
                .ThenInclude(l => l.Item)
                .Where(r => r.UserId == user.Id)
                .ToList();

            var loans = _context.Loans
                .Include(l => l.User)
                .Include(l => l.Item)
                .Where(l => l.UserId == user.Id && l.ReturnDate < DateTime.Now)
                .ToList();

            var hasSubscription = user.HasSubscription;
            var subscriptionType = GetSubscriptionTypeName(user.SubscriptionType); // Get the subscription type name

            var reservationFine = GetReservationFine(user.SubscriptionType);
            var reservationCharge = GetReservationCharge(user.SubscriptionType);
            _logger.LogInformation($"Reservation Fine: {reservationFine}, Reservation Charge: {reservationCharge}");

            var subscriptionCharge = GetSubscriptionCharge(user.SubscriptionType);
            _logger.LogInformation($"Subscription Charge: {subscriptionCharge}");

            var totalReservationCharge = reservations.Count * reservationCharge; // Calculate the total reservation charge

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
                TotalReservationCharge = totalReservationCharge // Set the total reservation charge property
            };

            ViewBag.HasSubscription = hasSubscription;

            return View(model);
        }






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









        public IActionResult Index(string searchString, string filter, string author, int? year)
        {
            if (HttpContext.Request.Path == "/loans")
            {
                // If the user is accessing the Loans page, return the view without updating item statuses
                return View(new List<Item>());
            }

            IQueryable<Item> itemsQuery = _context.Items.Include(i => i.Reservations);

            if (!string.IsNullOrEmpty(searchString))
            {
                itemsQuery = itemsQuery.Where(item =>
                    item.Title.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    item.Author.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    item.Location.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0);
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

            var items = itemsQuery.ToList();

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

            _context.SaveChanges(); // Save changes to the database to update the item statuses

            ViewBag.HasSubscription = false; // Set the initial value of HasSubscription to false

            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _userManager.FindByIdAsync(userId).Result;

                if (user != null)
                {
                    ViewBag.HasSubscription = user.HasSubscription; // Set the value of HasSubscription based on the user's subscription status
                }
            }

            return View(items);
        }







        [Authorize]
        public IActionResult Reserve(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _context.Items.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

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
            {
                _context.SaveChanges(); // Save changes to get the reservation ID
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



        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteReservation(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            TempData["Message"] = "Reservation deleted successfully.";

            return RedirectToAction(nameof(Profile));
        }


        [HttpGet("profile/{id}")]
        public async Task<IActionResult> Profile(int id)
        {
            var user = await _context.Users
                .Include(u => u.Reservations)
                    .ThenInclude(r => r.Loans)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new ProfileViewModel
            {
                User = user,
                Reservations = user.Reservations.ToList()
            };

            return View(viewModel);
        }


        [Authorize]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .FirstOrDefault(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User { UserName = model.Email, Name = model.Name, Email = model.Email, Type = model.Type };
                IdentityResult result;

                try
                {
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
                    _logger.LogError(ex, $"An error occurred while creating the user. Failed entities: {string.Join(", ", ex.Entries.Select(e => e.Entity.GetType().Name))}");

                    if (ex.InnerException != null)
                    {
                        _logger.LogError(ex.InnerException, $"Inner exception details:");
                    }

                    ModelState.AddModelError("", "An error occurred while creating the user.");
                    return View(model);
                }

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

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                ModelState.AddModelError("", error.ErrorMessage);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation($"Attempting to find user with email {model.Email}.");
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    _logger.LogInformation($"User {user.UserName} found. Attempting to sign in.");
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation($"User {user.UserName} successfully logged in.");
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        _logger.LogWarning($"Failed to log in user {user.UserName}. Sign-in result: {result}");
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View(model);
                    }
                }
                else
                {
                    _logger.LogWarning($"Failed to find user with email {model.Email}.");
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        public IActionResult Loan(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            if (user == null)
            {
                return NotFound();
            }

            var reservation = _context.Reservations
                .Include(r => r.Item)
                .FirstOrDefault(r => r.Id == id && r.UserId == user.Id);

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

            var loan = new Loan
            {
                UserId = user.Id,
                ItemId = item.Id,
                ReservationId = reservation.Id,
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(21)
            };

            _logger.LogInformation($"Trying to create loan: {loan}");
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

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Unsubscribe()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            if (user == null)
            {
                return NotFound();
            }

            user.HasSubscription = false; // Set the subscription status to false
            _context.SaveChanges();

            TempData["Message"] = "Subscription cancelled successfully.";

            return RedirectToAction(nameof(Profile));
        }

       



        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            TempData["Message"] = "Reservation deleted successfully.";

            return RedirectToAction(nameof(Profile));
        }
    }
}