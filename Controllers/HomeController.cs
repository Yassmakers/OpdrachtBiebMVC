using BiebWebApp.Data;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BiebWebAppContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(BiebWebAppContext context, UserManager<User> userManager, SignInManager<User> signInManager, ILogger<HomeController> logger)
        {
            _context = context;
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index(string searchString, string filter)
        {
            var items = _context.Items.ToList();

            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(item => item.Title.Contains(searchString) ||
                                            item.Author.Contains(searchString) ||
                                            item.Location.Contains(searchString)).ToList();
            }

            if (!string.IsNullOrEmpty(filter))
            {
                items = items.Where(item => item.Location == filter || item.ItemType.ToString() == filter).ToList();
            }

            return View(items);
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
                    // Set the role name based on the user type
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
    }
}
