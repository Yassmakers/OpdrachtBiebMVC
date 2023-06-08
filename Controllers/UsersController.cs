using BiebWebApp.Data;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BiebWebApp.Controllers
{


    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly ILogger<UsersController> _logger;
        private readonly BiebWebAppContext _context;

        public UsersController(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager, ILogger<UsersController> logger, BiebWebAppContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _context = context;
        }

        public IActionResult OpenBills()
        {
            // Retrieve users with open bills from the database
            var usersWithOpenBills = _context.Users
                .Include(u => u.Payments)
                .Where(u => u.Payments.Any(p => !p.IsPaid))
                .ToList();

            return View(usersWithOpenBills);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PayBill(int userId, int paymentId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var payment = user.Payments.FirstOrDefault(p => p.Id == paymentId);
            if (payment == null)
            {
                return NotFound();
            }

            payment.IsPaid = true;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                TempData["Message"] = "Payment processed successfully.";
            }
            else
            {
                AddErrors(result);
            }

            return RedirectToAction(nameof(OpenBills));
        }



        // GET: Users
        // Restrict access to admins and librarians
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && (user.Type == UserType.Administrator || user.Type == UserType.Librarian))
            {
                var users = await _userManager.Users.ToListAsync();
                return View(users);
            }
            else
            {
                return Content("This page is restricted for regular members.");
            }
        }
        private List<Location> GetLocations()
        {
            using (var context = new BiebWebAppContext(new DbContextOptions<BiebWebAppContext>()))
            {
                return context.Locations.ToList();
            }
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            var model = new RegisterModel();
            model.SubscriptionOptions = GetSubscriptionOptions();
            return View("Register", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            var user = new User
            {
                UserName = model.Email,
                Name = model.Name,
                Email = model.Email,
                Type = model.Type,
                SubscriptionType = model.SelectedSubscription.ToString(), // Set the selected subscription
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // Process the user creation
                return RedirectToAction(nameof(Index));
            }
            else
            {
                AddErrors(result);
            }

            // Repopulate subscription options in case of validation errors
            model.SubscriptionOptions = GetSubscriptionOptions();

            return View("Register", model);
        }

        // GET: Users/Edit/5
        // GET: Users/Edit/5
        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            var model = new EditUserModel
            {
                Id = user.Id,
                Name = user.Name,
                Type = user.Type,
                SubscriptionType = user.SubscriptionType, // Set the SubscriptionType property
                SubscriptionOptions = GetSubscriptionOptions() // Populate the SubscriptionOptions list
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditUserModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Model state is not valid.");
                _logger.LogError(string.Join("; ", ModelState.Values
                                                .SelectMany(state => state.Errors)
                                                .Select(error => error.ErrorMessage)));
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                _logger.LogError($"User with ID {id} not found.");
                return NotFound();
            }

            user.Name = model.Name;
            user.Type = model.Type;
            user.SubscriptionType = model.SubscriptionType;

            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                var passwordValidator = new PasswordValidator<User>();
                var result = await passwordValidator.ValidateAsync(_userManager, user, model.NewPassword);
                if (!result.Succeeded)
                {
                    _logger.LogError("Password validation failed: {0}", string.Join("; ", result.Errors.Select(e => e.Description)));
                    AddErrors(result);
                    model.SubscriptionOptions = GetSubscriptionOptions();
                    return View(model);
                }

                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.NewPassword);
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                _logger.LogError("Failed to update user: {0}", string.Join("; ", updateResult.Errors.Select(e => e.Description)));
                AddErrors(updateResult);
            }

            if (updateResult.Succeeded)
            {
                return RedirectToAction(nameof(Details), new { id = user.Id });
            }

            model.SubscriptionOptions = GetSubscriptionOptions();
            return View(model);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Block(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            user.IsBlocked = true;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                TempData["Message"] = "User blocked successfully.";
            }
            else
            {
                AddErrors(result);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unblock(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            user.IsBlocked = false;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                TempData["Message"] = "User unblocked successfully.";
            }
            else
            {
                AddErrors(result);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await FindUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            AddErrors(result);
            return View(user);
        }

        private List<SelectListItem> GetSubscriptionOptions()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "No Subscription" },
                new SelectListItem { Value = "1", Text = "Youth Subscription" },
                new SelectListItem { Value = "2", Text = "Budget Subscription" },
                new SelectListItem { Value = "3", Text = "Basic Subscription" },
                new SelectListItem { Value = "4", Text = "Top Subscription" }
            };
        }

        private async Task<User> FindUserById(int id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(e => e.Id == id);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
