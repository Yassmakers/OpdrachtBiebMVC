using BiebWebApp.Data;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
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

        public IActionResult Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.FindByIdAsync(userId).Result;

            var reservations = _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .Where(r => r.UserId == user.Id)
                .ToList();

            var model = new ProfileViewModel
            {
                User = user,
                Reservations = reservations
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
                ItemId = item.Id,
                UserId = user.Id,
                ReservationDate = DateTime.Now
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            TempData["Message"] = "Reservation created successfully.";

            return RedirectToAction(nameof(Profile));
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
