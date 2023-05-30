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

            var reservations = _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .Include(r => r.Loans) // Include the Loans navigation property
                .ThenInclude(l => l.Item) // Include the Item associated with the Loan
                .Where(r => r.UserId == user.Id)
                .ToList();

            var model = new ProfileViewModel
            {
                User = user,
                Reservations = reservations ?? new List<Reservation>()
            };

            return View(model);
        }



        public IActionResult Index(string searchString, string filter, string author, int? year)
        {
            var items = _context.Items.ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(item => item.Title.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                            item.Author.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                            item.Location.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            if (!string.IsNullOrEmpty(filter))
            {
                ItemType itemType;
                if (Enum.TryParse(filter, out itemType))
                {
                    items = items.Where(item => item.ItemType == itemType).ToList();
                }
            }

            if (!string.IsNullOrEmpty(author))
            {
                items = items.Where(item => item.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            if (year != null)
            {
                items = items.Where(item => item.Year == year).ToList();
            }

            return View(items);
        }

        [Authorize]
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

            var reservation = new Reservation
            {
                UserId = user.Id,
                ItemId = item.Id,
                ReservationDate = DateTime.Now
            };

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

            var loan = new Loan
            {
                UserId = user.Id,
                ItemId = item.Id,
                ReservationId = reservation.Id, // Assign the reservation ID to the loan
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(21) // Set the return date to 3 weeks from now
            };

            _logger.LogInformation($"Trying to create loan: {loan}");
            _context.Loans.Add(loan);

            try
            {
                _context.SaveChanges(); // Save changes to add the loan
                _logger.LogInformation($"Loan with ID {loan.Id} created successfully.");
            }
            catch (Exception e)
            {
                _logger.LogError($"Exception occurred while saving loan: {e}");
                return View("Error");
            }

            TempData["Message"] = "Reservation created successfully.";

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

            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            if (user == null)
            {
                return NotFound();
            }

            var loan = new Loan
            {
                UserId = user.Id,
                ItemId = reservation.ItemId,
                ReservationId = reservation.Id, // Assign the reservation ID to the loan
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(21) // Set the return date to 3 weeks from now
            };

            _logger.LogInformation($"Trying to create loan: {loan}");
            _context.Loans.Add(loan);

            try
            {
                _context.SaveChanges(); // Save changes to add the loan
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
