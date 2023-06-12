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

        // GET: Users
        // Restrict access to admins and librarians
        public async Task<IActionResult> Index()
        {
            // Retrieve the current user
            var user = await _userManager.GetUserAsync(User);

            // Check if the user exists and is an admin or librarian
            if (user != null && (user.Type == UserType.Administrator || user.Type == UserType.Librarian))
            {
                // Retrieve the list of users based on user role
                var users = await GetUserListByRole(user);

                // Pass the list of users to the view for rendering
                return View(users);
            }
            else
            {
                // Return a simple content response indicating the restriction for regular members
                return Content("This page is restricted for regular members.");
            }
        }

        // Helper method to retrieve the list of users based on user role
       private async Task<IEnumerable<User>> GetUserListByRole(User user)
{
    if (user.Type == UserType.Librarian)
    {
        // For librarians, retrieve only members
        return await _userManager.Users.Where(u => u.Type == UserType.Member).ToListAsync();
    }
    else if (user.Type == UserType.Administrator)
    {
        // For admins, retrieve all users
        return await _userManager.Users.ToListAsync();
    }
    else
    {
        return Enumerable.Empty<User>();
    }
}


        // Helper method to retrieve a list of locations from the database
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
            // Find the user by ID
            var user = await FindUserById(id);
            
            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Pass the user object to the view for rendering the details
            return View(user);
        }

        // GET: Users/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            // Create a new RegisterModel and set the subscription options
            var model = new RegisterModel();
            model.SubscriptionOptions = GetSubscriptionOptions();
            
            // Return the Register view with the model
            return View("Register", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            // Create a new User object with the provided properties from the model
            var user = new User
            {
                UserName = model.Email,
                Name = model.Name,
                Email = model.Email,
                Type = model.Type,
                SubscriptionType = model.SelectedSubscription.ToString(), // Set the selected subscription
            };

            // Attempt to create the user using the UserManager
            var result = await _userManager.CreateAsync(user, model.Password);
            
            // If the user creation is successful, redirect to the Index action
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                // If there are errors, add them to the ModelState
                AddErrors(result);
            }

            // Repopulate subscription options in case of validation errors
            model.SubscriptionOptions = GetSubscriptionOptions();

            // Return the Register view with the model
            return View("Register", model);
        }

        // UsersController

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);

            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Create a new EditUserModel and set its properties based on the user
            var model = new EditUserModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                SubscriptionType = user.SubscriptionType,
                SubscriptionOptions = GetSubscriptionOptions()
            };

            // If the user is a librarian, restrict the UserType options to Member
            if (User.IsInRole("Librarian"))
            {
                model.Type = UserType.Member;
                model.SubscriptionOptions.RemoveAll(option => option.Value != "1"); // Remove other subscription options
            }
            else
            {
                model.Type = user.Type;
            }

            // Return the Edit view with the model
            return View(model);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditUserModel model)
        {
            // Check if the provided ID matches the model ID
            if (id != model.Id)
            {
                return NotFound();
            }

            // Check if the ModelState is valid
            if (!ModelState.IsValid)
            {
                // Log an error and retrieve the error messages
                _logger.LogError("Model state is not valid.");
                _logger.LogError(string.Join("; ", ModelState.Values
                                                .SelectMany(state => state.Errors)
                                                .Select(error => error.ErrorMessage)));
            }

            // Find the user by ID
            var user = await _userManager.FindByIdAsync(id.ToString());

            // If the user is not found, return a NotFound response
            if (user == null)
            {
                _logger.LogError($"User with ID {id} not found.");
                return NotFound();
            }

            // Update the user properties based on the model
            user.Name = model.Name;
            user.Email = model.Email; // Update the Email property
            user.Type = model.Type;
            user.SubscriptionType = model.SubscriptionType;

            // Check if a new password is provided
            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                // Validate the new password using a PasswordValidator
                var passwordValidator = new PasswordValidator<User>();
                var result = await passwordValidator.ValidateAsync(_userManager, user, model.NewPassword);

                // If the password validation fails, log the error and add errors to the ModelState
                if (!result.Succeeded)
                {
                    _logger.LogError("Password validation failed: {0}", string.Join("; ", result.Errors.Select(e => e.Description)));
                    AddErrors(result);

                    // Repopulate subscription options in case of validation errors
                    model.SubscriptionOptions = GetSubscriptionOptions();

                    // Return the Edit view with the model
                    return View(model);
                }

                // Hash and set the new password for the user
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.NewPassword);
            }

            // Update the user using the UserManager
            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                _logger.LogError("Failed to update user: {0}", string.Join("; ", updateResult.Errors.Select(e => e.Description)));
                AddErrors(updateResult);
            }

            // If the user update is successful, redirect to the Details action
            if (updateResult.Succeeded)
            {
                return RedirectToAction(nameof(Details), new { id = user.Id });
            }

            // If there are errors, add them to the ModelState
            AddErrors(updateResult);

            // Repopulate subscription options in case of validation errors
            model.SubscriptionOptions = GetSubscriptionOptions();

            // Return the Edit view with the model
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Block(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);
            
            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Set the user's IsBlocked property to true
            user.IsBlocked = true;

            // Update the user using the UserManager
            var result = await _userManager.UpdateAsync(user);
            
            // If the user update is successful, set a success message in TempData
            if (result.Succeeded)
            {
                TempData["Message"] = "User blocked successfully.";
            }
            else
            {
                // If there are errors, add them to the ModelState
                AddErrors(result);
            }

            // Redirect to the Index action
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unblock(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);
            
            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Set the user's IsBlocked property to false
            user.IsBlocked = false;

            // Update the user using the UserManager
            var result = await _userManager.UpdateAsync(user);
            
            // If the user update is successful, set a success message in TempData
            if (result.Succeeded)
            {
                TempData["Message"] = "User unblocked successfully.";
            }
            else
            {
                // If there are errors, add them to the ModelState
                AddErrors(result);
            }

            // Redirect to the Index action
            return RedirectToAction(nameof(Index));
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);
            
            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Return the Delete view with the user object
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);

            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Check if there are any loans associated with the user
            var loans = _context.Loans.Where(l => l.Reservation.User == user).ToList();

            if (loans.Count > 0)
            {
                // Delete the loans associated with the user
                _context.Loans.RemoveRange(loans);
                await _context.SaveChangesAsync();
            }

            // Delete the user using the UserManager
            var result = await _userManager.DeleteAsync(user);

            // If the user deletion is successful, redirect to the Index action
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            // If there are errors, add them to the ModelState
            AddErrors(result);

            // Return the Delete view with the user object
            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkAsPaid(int id)
        {
            // Find the user by ID
            var user = await FindUserById(id);
            
            // If the user is not found, return a NotFound response
            if (user == null)
            {
                return NotFound();
            }

            // Set the user's HasPaid property to true
            user.HasPaid = true;

            // Update the user using the UserManager
            var result = await _userManager.UpdateAsync(user);
            
            // If the user update is successful, set a success message in TempData
            if (result.Succeeded)
            {
                TempData["Message"] = "Payment status updated successfully.";
            }
            else
            {
                // If there are errors, add them to the ModelState
                AddErrors(result);
            }

            // Redirect to the Details action
            return RedirectToAction(nameof(Details), new { id });
        }

        // Helper method to retrieve a list of subscription options
        private List<SelectListItem> GetSubscriptionOptions()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Youth Subscription" },
                new SelectListItem { Value = "2", Text = "Budget Subscription" },
                new SelectListItem { Value = "3", Text = "Basic Subscription" },
                new SelectListItem { Value = "4", Text = "Top Subscription" }
            };
        }

        // Helper method to find a user by ID
        private async Task<User> FindUserById(int id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(e => e.Id == id);
        }

        // Helper method to add errors to the ModelState
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
