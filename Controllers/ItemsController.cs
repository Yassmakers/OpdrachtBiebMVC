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

            return View(model);
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
