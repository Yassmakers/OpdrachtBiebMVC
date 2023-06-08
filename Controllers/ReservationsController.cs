using BiebWebApp.Data;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BiebWebApp.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly BiebWebAppContext _context;

        private readonly UserManager<User> _userManager;

        public ReservationsController(BiebWebAppContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }




        // GET: Reservations
        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && (user.Type == UserType.Administrator || user.Type == UserType.Librarian))
            {
                var reservations = await _context.Reservations
                    .Include(r => r.User)
                    .Include(r => r.Item)
                    .ToListAsync();

                return View(reservations);
            }
            else
            {
                return Content("This page is restricted for regular members.");
            }
        }


        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create(int itemId)
        {
            // Retrieve the item based on the provided itemId
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);

            if (item == null)
            {
                // Item not found, handle the error accordingly (e.g., show an error message, redirect, etc.)
                return NotFound();
            }

            // Retrieve the users and pass them to the ViewBag
            var users = _context.Users.Select(u => new SelectListItem { Value = u.Id.ToString(), Text = u.Name });
            ViewBag.UserId = users;

            var reservation = new Reservation
            {
                ItemId = item.Id,
                Item = item
            };

            return View(reservation);
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ItemId,ReservationDate")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name", reservation.UserId);
            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Title", reservation.ItemId);
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }

            // Retrieve the users and items and pass them to the ViewBag
            var users = _context.Users.Select(u => new SelectListItem { Value = u.Id.ToString(), Text = u.Name });
            ViewBag.UserId = users;

            var items = _context.Items.Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Title });
            ViewBag.ItemId = items;

            return View(reservation);
        }

        // POST: Reservations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ItemId,ReservationDate")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Reservation updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name", reservation.UserId);
            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Title", reservation.ItemId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Item)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations
                .Include(r => r.Loans) // Include the associated loans
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reservation == null)
            {
                return NotFound();
            }

            // Delete the loans associated with the reservation
            _context.Loans.RemoveRange(reservation.Loans);

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            TempData["Message"] = "Reservation deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }
}
