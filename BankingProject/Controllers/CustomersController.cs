using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankingProject.Data;
using BankingProject.Models;
using BankingProject.DataAccess;

namespace BankingProject.Controllers
{
    public class CustomersController : Controller
    {
        private readonly BankingDbContext _context;

        public CustomersController(BankingDbContext context)
        {
            _context = context;
        }

        // GET: Costumers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Costumers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CostumerId == id);
            if (costumer == null)
            {
                return NotFound();
            }

            return View(costumer);
        }

        // GET: Costumers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Costumers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CostumerId,FirstName,LastName,SocialId")] Costumer costumer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(costumer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(costumer);
        }

        // GET: Costumers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer = await _context.Costumers.FindAsync(id);
            if (costumer == null)
            {
                return NotFound();
            }
            return View(costumer);
        }

        // POST: Costumers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CostumerId,FirstName,LastName,SocialId")] Costumer costumer)
        {
            if (id != costumer.CostumerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(costumer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CostumerExists(costumer.CostumerId))
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
            return View(costumer);
        }

        // GET: Costumers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer = await _context.Costumers
                .FirstOrDefaultAsync(m => m.CostumerId == id);
            if (costumer == null)
            {
                return NotFound();
            }

            return View(costumer);
        }

        // POST: Costumers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var costumer = await _context.Costumers.FindAsync(id);
            _context.Costumers.Remove(costumer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CostumerExists(int id)
        {
            return _context.Costumers.Any(e => e.CostumerId == id);
        }
    }
}
