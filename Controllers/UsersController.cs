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

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Name = model.Name,
                    Email = model.Email,
                    Type = model.Type,
                    SubscriptionType = model.SelectedSubscription, // Set the selected subscription
                    MaxItemsPerYear = GetMaxItemsPerYear(model.SelectedSubscription) // Set the maximum items per year based on the selected subscription
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
            }

            // Repopulate subscription options in case of validation errors
            model.SubscriptionOptions = GetSubscriptionOptions();
            model.MaxItemsPerYear = GetMaxItemsPerYear(model.SelectedSubscription); // Update the MaxItemsPerYear property in the model

            return View("Register", model);
        }

        private List<SelectListItem> GetSubscriptionOptions()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "None", Text = "No Subscription" },
                new SelectListItem { Value = "Youth", Text = "Youth Subscription" },
                new SelectListItem { Value = "Budget", Text = "Budget Subscription" },
                new SelectListItem { Value = "Basic", Text = "Basic Subscription" },
                new SelectListItem { Value = "Top", Text = "Top Subscription" }
                // Add more options if needed
            };
        }

        private int GetMaxItemsPerYear(string subscriptionType)
        {
            switch (subscriptionType)
            {
                case "None":
                    return 0; // No subscription has a maximum of 0 items per year
                case "Youth":
                    return int.MaxValue; // Youth subscription has unlimited items per year
                case "Budget":
                    return 10; // Budget subscription has a maximum of 10 items per year
                case "Basic":
                    return int.MaxValue; // Basic subscription has unlimited items per year
                case "Top":
                    return int.MaxValue; // Top subscription has unlimited items per year
                default:
                    return 0; // Default to 0 if the subscription type is not recognized
            }
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
