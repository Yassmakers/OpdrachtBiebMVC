using BiebWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiebWebApp.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public UsersController(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _userManager.Users.ToListAsync());
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

            if (ModelState.IsValid)
            {
                var user = await FindUserById(id);
                if (user == null)
                {
                    return NotFound();
                }

                user.Name = model.Name;
                user.Type = model.Type;
                user.SubscriptionType = model.SubscriptionType;

                if (!string.IsNullOrEmpty(model.NewPassword))
                {
                    var passwordValidator = new PasswordValidator<User>();
                    var result = await passwordValidator.ValidateAsync(_userManager, user, model.NewPassword);
                    if (result.Succeeded)
                    {
                        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.NewPassword);
                    }
                    else
                    {
                        AddErrors(result);
                        model.SubscriptionOptions = GetSubscriptionOptions();
                        return View(model);
                    }
                }

                var updateResult = await _userManager.UpdateAsync(user);
                if (updateResult.Succeeded)
                {
                    return RedirectToAction(nameof(Details), new { id = user.Id });
                }
                else
                {
                    AddErrors(updateResult);
                }
            }

            model.SubscriptionOptions = GetSubscriptionOptions();
            return View(model);
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
            else
            {
                AddErrors(result);
                return View(user);
            }
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
                // Add more options if needed
            };
        }

        // Helper method to find a user by id
        private async Task<User> FindUserById(int id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(e => e.Id == id);
        }

        // Helper method to check if a user exists
        private bool UserExists(int id)
        {
            return _userManager.Users.Any(e => e.Id == id);
        }

        // Helper method to add errors to the model state
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}
