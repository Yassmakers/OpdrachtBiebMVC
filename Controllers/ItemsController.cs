using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiebWebApp.Data;
using BiebWebApp.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BiebWebApp.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly BiebWebAppContext _context;

        public ItemsController(BiebWebAppContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private readonly UserManager<User> _userManager;
        
        // GET: Items
        // Displays the list of items if the user is an administrator or librarian.
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null && (user.Type == UserType.Administrator || user.Type == UserType.Librarian))
            {
                var items = await _context.Items.ToListAsync();
                return View(items);
            }
            else
            {
                return Content("This page is restricted for regular members.");
            }
        }


        // GET: Items/Details/5
        // Displays details of a specific item.
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
        // Displays the item creation form.
        public IActionResult Create()
        {
            // Get the distinct list of location names and pass it to the view
            ViewBag.Locations = _context.Locations.Select(l => l.LocationName).Distinct().ToList();
            return View();
        }

        // POST: Items/Create
        // Creates a new item based on the form data.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateItemModel model)
        {
            if (ModelState.IsValid)
            {
                // Create a new item object and populate its properties with the form data
                var item = new Item
                {
                    Title = model.Title,
                    Author = model.Author,
                    ItemType = model.ItemType,
                    Year = model.Year,
                    Location = model.Location,
                    Status = model.Status
                };

                // Add the item to the context and save changes to the database
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Items/Edit/5
        // Displays the edit form for a specific item.
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find the item with the specified id
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            // Create an EditItemModel object and populate its properties with the item's details
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

            // Get the distinct list of location names and pass it to the view
            ViewBag.Locations = await _context.Locations.Select(l => l.LocationName).Distinct().ToListAsync();

            return View(model);
        }


        // GET: Items/DeleteLocation
        // Displays the view to delete a location.
        public IActionResult DeleteLocation()
        {
            // Get the list of all locations and pass it to the view
            var locations = _context.Locations.ToList();
            return View(locations);
        }

        // POST: Items/DeleteLocationConfirmed
        // Deletes a location confirmed by the user.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteLocationConfirmed(int locationId)
        {
            // Find the location with the specified id
            var location = await _context.Locations.FindAsync(locationId);
            if (location == null)
            {
                return NotFound();
            }

            // Remove the location from the context and save changes to the database
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DeleteLocation));
        }



        // POST: Items/Edit/5
        // Updates the details of an item based on the form data.
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
                    // Find the item with the specified id
                    var item = await _context.Items.FindAsync(id);
                    if (item == null)
                    {
                        return NotFound();
                    }

                    // Update the item's properties with the values from the form model
                    item.Title = model.Title;
                    item.Author = model.Author;
                    item.ItemType = model.ItemType;
                    item.Year = model.Year;
                    item.Location = model.Location;
                    item.Status = model.Status;

                    // Update the item in the database
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    // If the item being edited no longer exists in the database,
                    // return a 404 NotFound error.
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

            // Retrieve the list of distinct locations and pass it to the view
            ViewBag.Locations = await _context.Items.Select(i => i.Location).Distinct().ToListAsync();

            return View(model);
        }

        // GET: Items/Delete/5
        // Displays the delete confirmation view for a specific item.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Find the item with the specified id
            var item = await _context.Items
                .FirstOrDefaultAsync(m => m.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        // Deletes an item confirmed by the user.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Find the item with the specified id
            var item = await _context.Items.FindAsync(id);
            
            // Remove the item from the context and save changes to the database
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // Checks if an item with the specified id exists in the database.
        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.Id == id);
        }

        // GET: Items/CreateLocation
        // Displays the create location form.
        public IActionResult CreateLocation()
        {
            return View();
        }

        // POST: Items/CreateLocation
        // Creates a new location based on the form data.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLocation(CreateLocationModel model)
        {
            if (ModelState.IsValid)
            {
                // Create a new location object and populate its properties with the form data
                var location = new Location
                {
                    LocationName = model.LocationName
                };

                // Add the location to the context and save changes to the database
                _context.Locations.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
