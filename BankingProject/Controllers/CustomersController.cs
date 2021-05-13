using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankingProject.ApplicationLogic.Services;
using Microsoft.AspNetCore.Identity;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerService service;
        private readonly AccountsService accountsService;
        private readonly UserManager<IdentityUser> userManager;
        public CustomersController(CustomerService _service, UserManager<IdentityUser> userManager, AccountsService accountsService)
        {
            this.service=_service;
            this.userManager = userManager;
            this.accountsService = accountsService;
        }

        // GET: Costumers
        public IActionResult Index()
        {
            return View(service.GetCustomers().OrderBy(s=>s.FirstName));
        }

        // GET: Costumers/Details/5
        public IActionResult Details(string id)
        {
            var costumer = service.GetCustomerFromUserId(id);
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
        /*
        // POST: Costumers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CostumerId,FirstName,LastName,SocialId")] Customer costumer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(costumer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(costumer);
        }
        */
        // GET: Costumers/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer = service.GetCustomerFromUserId(id);
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
        public IActionResult Edit(string id, [Bind("CostumerId,FirstName,LastName,SocialId")] Customer costumer)
        {
            Guid idG = Guid.Parse(id);
            if (idG != costumer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                service.UpdateCustomer(costumer);
                return RedirectToAction(nameof(Index));
            }
            return View(costumer);
        }
        
        // get: costumers/delete/5
        public IActionResult Delete(string id)
        {

            var costumer = service.GetCustomerFromUserId(id);
            return View(costumer);
        }

        // post: costumers/delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var customer = service.GetCustomerFromUserId(id);
            service.RemoveCustomer(customer.Id.ToString());
            return RedirectToAction(nameof(Index));
        }
    }
}
