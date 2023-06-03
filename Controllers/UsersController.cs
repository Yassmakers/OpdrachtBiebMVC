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
        private readonly ILogger<UsersController> _logger;

        public UsersController(UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager, ILogger<UsersController> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
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
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Name = model.Name,
                    Email = model.Email,
                    Type = model.Type,
                    SubscriptionType = model.SelectedSubscription.ToString(),
                    IsBlocked = false
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }

                AddErrors(result);
            }

            model.SubscriptionOptions = GetSubscriptionOptions();
            return View("Register", model);
        }

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
                SubscriptionType = user.SubscriptionType,
                SubscriptionOptions = GetSubscriptionOptions(),
                IsBlocked = user.IsBlocked
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
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            user.Name = model.Name;
            user.Type = model.Type;
            user.SubscriptionType = model.SubscriptionType;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            AddErrors(result);
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
