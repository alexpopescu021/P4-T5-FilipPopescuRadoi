using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankingProject.ApplicationLogic.Model;
using BankingProject.DataAccess;
using BankingProject.ApplicationLogic.Services;
using Microsoft.AspNetCore.Identity;

namespace BankingProject.Controllers
{
    public class RequestsController : Controller
    {
        private readonly RequestsService requestsService;
        private readonly CardServices cardServices;
        private readonly LoanService loanService;
        private readonly CustomerService customerService;

        private readonly UserManager<IdentityUser> userManager;

        public RequestsController(RequestsService requestsService, CardServices cardServices, 
            LoanService loanService, UserManager<IdentityUser> userManager,
            CustomerService customerService)
        {
            this.requestsService=requestsService;
            this.cardServices = cardServices;
            this.loanService = loanService;
            this.userManager = userManager;
            this.customerService = customerService;
        }

        // GET: Requests
        public IActionResult Index()
        {
            return View(requestsService.GetRequests().OrderBy(s=>s.Status));
        }

        public IActionResult UserRequests()
        {
            var customer = customerService.GetCustomerFromUserId(userManager.GetUserId(User));
            return View(requestsService.GetRequestsByCustomerId(customer.Id.ToString()).OrderBy(s=>s.Status));
        }

        // GET: Requests/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = requestsService.GetRequestById(id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }
        /*
        // GET: Requests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,Type,SendDate")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(request);
        }
        */
        // GET: Requests/Edit/5
        public IActionResult Accept(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = requestsService.GetRequestById(id);
            request.Status++;
            requestsService.UpdateReq(request);
            //var customer = customerService.GetCustomerFromUserId(userManager.GetUserId(User));
            if (request.Type == "Card")
            {
                var card = new Card
                {
                    SerialNumber = "12345678",
                    CVV = 111,
                    CreateDate = DateTime.Now,
                    ExpDate = DateTime.Now.AddYears(4),
                    OwnerName = "Teodora Radoi",
                };
                cardServices.AddCard(card);
            } else if(request.Type == "Loan")
            {
                var loan = new Loan
                {
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddYears(4),
                    Value = 10000,
                    LunarFee = 100,
                };
                loanService.AddLoan(loan);
            }
            if (request == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Decline(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = requestsService.GetRequestById(id);
            request.Status++;
            request.Status++;
            requestsService.UpdateReq(request);
            if (request == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("RequestId,Type,SendDate")] Request request)
        {
            if (id != request.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    requestsService.UpdateReq(request);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.Id))
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
            return View(request);
        }
        /*
        // GET: Requests/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Requests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        */
        private bool RequestExists(Guid id)
        {
            var request = requestsService.GetRequestById(id.ToString());
            if (request != null)
            {
                return true;
            }
            return false;
        }
    }
}
