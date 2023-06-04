using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiebWebApp.Data;
using BiebWebApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BiebWebApp.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly BiebWebAppContext _context;

        public ItemsController(BiebWebAppContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();
            return View(items);
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
            ViewBag.Locations = _context.Locations.Select(l => l.LocationName).Distinct().ToList();
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateItemModel model)
        {
            if (ModelState.IsValid)
            {
                var item = new Item
                {
                    Title = model.Title,
                    Author = model.Author,
                    ItemType = model.ItemType,
                    Year = model.Year,
                    Location = model.Location,
                    Status = model.Status
                };

                _context.Items.Add(item);
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

            var model = new EditItemModel
            {
                Id = item.Id,
                Title = item.Title,
                Author = item.Author,
                ItemType = item.ItemType,
                Year = item.Year,
                Location = item.Location,
                Status = item.Status
            };

            ViewBag.Locations = await _context.Locations.Select(l => l.LocationName).Distinct().ToListAsync();

            return View(model);
        }


        // GET: Items/DeleteLocation
        public IActionResult DeleteLocation()
        {
            var locations = _context.Locations.ToList();
            return View(locations);
        }

        // POST: Items/DeleteLocationConfirmed
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLocationConfirmed(int locationId)
        {
            var location = await _context.Locations.FindAsync(locationId);
            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DeleteLocation));
        }



        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditItemModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var item = await _context.Items.FindAsync(id);
                    if (item == null)
                    {
                        return NotFound();
                    }

                    item.Title = model.Title;
                    item.Author = model.Author;
                    item.ItemType = model.ItemType;
                    item.Year = model.Year;
                    item.Location = model.Location;
                    item.Status = model.Status;

                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(id))
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

            ViewBag.Locations = await _context.Items.Select(i => i.Location).Distinct().ToListAsync();

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

        // GET: Items/CreateLocation
        public IActionResult CreateLocation()
        {
            return View();
        }

        // POST: Items/CreateLocation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLocation(CreateLocationModel model)
        {
            if (ModelState.IsValid)
            {
                var location = new Location
                {
                    LocationName = model.LocationName
                };

                _context.Locations.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
