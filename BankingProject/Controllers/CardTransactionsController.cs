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
    public class CardTransactionsController : Controller
    {
        private readonly BankingDbContext _context;


        public CardTransactionsController(BankingDbContext context)
        {
            _context = context;
        }

        // GET: CardTransactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.CardTransactions.ToListAsync());
        }

        // GET: CardTransactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTransaction = await _context.CardTransactions
                .FirstOrDefaultAsync(m => m.CardTransactionId == id);
            if (cardTransaction == null)
            {
                return NotFound();
            }

            return View(cardTransaction);
        }

        // GET: CardTransactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CardTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CardTransactionId,ExternalIBAN,ExternalName,Amount,Time,Details,Status")] CardTransaction cardTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cardTransaction);
        }

        // GET: CardTransactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTransaction = await _context.CardTransactions.FindAsync(id);
            if (cardTransaction == null)
            {
                return NotFound();
            }
            return View(cardTransaction);
        }

        // POST: CardTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CardTransactionId,ExternalIBAN,ExternalName,Amount,Time,Details,Status")] CardTransaction cardTransaction)
        {
            if (id != cardTransaction.CardTransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardTransactionExists(cardTransaction.CardTransactionId))
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
            return View(cardTransaction);
        }

        // GET: CardTransactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTransaction = await _context.CardTransactions
                .FirstOrDefaultAsync(m => m.CardTransactionId == id);
            if (cardTransaction == null)
            {
                return NotFound();
            }

            return View(cardTransaction);
        }

        // POST: CardTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardTransaction = await _context.CardTransactions.FindAsync(id);
            _context.CardTransactions.Remove(cardTransaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardTransactionExists(int id)
        {
            return _context.CardTransactions.Any(e => e.CardTransactionId == id);
        }
    }
}
