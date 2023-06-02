﻿using BiebWebApp.Data;
using BiebWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace BiebWebApp.Controllers
{
    public class LoansController : Controller
    {
        private readonly BiebWebAppContext _context;

        public LoansController(BiebWebAppContext context)
        {
            _context = context;
        }

        // GET: Loans
        // GET: Loans
        public async Task<IActionResult> Index(string searchString)
        {
            var loansQuery = _context.Loans.Include(l => l.User).Include(l => l.Item);

            if (!string.IsNullOrEmpty(searchString))
            {
                loansQuery = loansQuery.Where(l => l.User.Name.Contains(searchString))
                                       .Include(l => l.Item);
            }

            var loans = await loansQuery.ToListAsync();

            return View(loans);
        }

        // GET: Loans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .Include(l => l.User)
                .Include(l => l.Item)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        // GET: Loans/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name");
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Title");
            return View();
        }

        // POST: Loans/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ItemId,LoanDate,ReturnDate")] Loan loan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", loan.UserId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Title", loan.ItemId);
            return View(loan);
        }

        // GET: Loans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", loan.UserId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Title", loan.ItemId);
            return View(loan);
        }

        // POST: Loans/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ItemId,LoanDate,ReturnDate")] Loan loan)
        {
            if (id != loan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanExists(loan.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Name", loan.UserId);
            ViewData["ItemId"] = new SelectList(_context.Items, "Id", "Title", loan.ItemId);
            return View(loan);
        }

        // GET: Loans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .Include(l => l.User)
                .Include(l => l.Item)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        // GET: Loans/Return/5
        // GET: Loans/Return/5
        public async Task<IActionResult> Return(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loans
                .Include(l => l.Item)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (loan == null)
            {
                return NotFound();
            }

            loan.ReturnDate = DateTime.Now;

            var item = loan.Item;
            if (item != null && item.Status == ItemStatus.Loaned)
            {
                item.Status = ItemStatus.Available;
            }

            // Retrieve the associated reservation for the returned item
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == loan.ReservationId);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }

            TempData["Message"] = "Item returned successfully.";

            return RedirectToAction(nameof(Index));
        }





        // POST: Loans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanExists(int id)
        {
            return _context.Loans.Any(e => e.Id == id);
        }
    }
}