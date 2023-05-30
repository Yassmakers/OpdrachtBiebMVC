using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiebWebApp.Data;
using BiebWebApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace BiebWebApp.Controllers
{
    public class ItemsController : Controller
    {
        private readonly BiebWebAppContext _context;

        public ItemsController(BiebWebAppContext context)
        {
            _context = context;
        }

        // GET: Items/Reserve/5
        [Authorize] // Ensure the user is logged in
        public async Task<IActionResult> Reserve(int? itemId)
        {
            if (itemId == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(itemId);
            if (item == null)
            {
                return NotFound();
            }

            // Get the current user's ID
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userIdString, out var userId))
            {
                // Handle error here: the user ID was not an integer
                return BadRequest();
            }

            // Create a new reservation
            var reservation = new Reservation
            {
                ItemId = item.Id,
                UserId = userId,
                ReservationDate = DateTime.Now,
                Item = item // Include the item in the reservation
            };

            return View(reservation); // Returns a view that asks the user to confirm the reservation
        }


        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> ReserveConfirmed(Reservation reservation)
        {
            // Check if the user has already reserved the item (additional validation)
            var existingReservation = await _context.Reservations
                .FirstOrDefaultAsync(r => r.ItemId == reservation.ItemId && r.UserId == reservation.UserId);

            if (existingReservation != null)
            {
                TempData["Message"] = "You have already reserved this item."; // Set error message
                return RedirectToAction("Index", "Home"); // Redirect to the home view index
            }

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Reservation completed successfully."; // Set success message

            return RedirectToAction("Index", "Home"); // Redirect to the home view index
        }


        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,ItemType,Year,Location,Status")] Item model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,ItemType,Year,Location,Status")] Item model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }
    }
}