using BiebWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return View("Register");
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
                    Type = model.Type
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    string roleName;
                    switch (user.Type)
                    {
                        case UserType.Member:
                            roleName = UserType.Member.ToString();
                            break;
                        case UserType.Librarian:
                            roleName = UserType.Librarian.ToString();
                            break;
                        case UserType.Administrator:
                            roleName = UserType.Administrator.ToString();
                            break;
                        default:
                            throw new ArgumentException("Invalid user type");
                    }

                    if (!await _roleManager.RoleExistsAsync(roleName))
                    {
                        await _roleManager.CreateAsync(new IdentityRole<int> { Name = roleName });
                    }

                    await _userManager.AddToRoleAsync(user, roleName);

                    return RedirectToAction(nameof(Index));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

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
                Type = user.Type
            };

            return View(model);
        }

        // POST: Users/Edit/5
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
                try
                {
                    var existingUser = await FindUserById(id);
                    if (existingUser == null)
                    {
                        return NotFound();
                    }

                    existingUser.Name = model.Name;
                    existingUser.Type = model.Type;

                    await _userManager.UpdateAsync(existingUser); // Update the user

                    // Redirect to the details page instead of the index page
                    return RedirectToAction(nameof(Details), new { id = existingUser.Id });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

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
            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }

        private async Task<User> FindUserById(int id)
        {
            return await _userManager.Users.FirstOrDefaultAsync(e => e.Id == id);
        }



        private bool UserExists(int id)
        {
            return _userManager.Users.Any(e => e.Id == id);
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
