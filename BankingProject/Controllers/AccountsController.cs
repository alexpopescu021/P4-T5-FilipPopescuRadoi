using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankingProject.DataAccess;
using BankingProject.ApplicationLogic.Model;
using BankingProject;
using Microsoft.AspNetCore.Authorization;
using BankingProject.ApplicationLogic.Services;
using Microsoft.AspNetCore.Identity;
using BankingProject.ViewModel.Accounts;
using BankingProject.ApplicationLogic.Exceptions;

namespace BankingProject.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly MetaDataService metaDataService;

        private readonly AccountsService accountsService;
        private readonly CustomerService customerService;
        private readonly PaymentsService paymentsService;
        private readonly RequestsService requestsService;
        private readonly UserManager<IdentityUser> userManager;

        public AccountsController(AccountsService customerServices,
                                  MetaDataService metaDataService,
                                  CustomerService customerService,
                                  PaymentsService paymentsService, RequestsService requestsService,
                                  UserManager<IdentityUser> userManager)
        {
            this.metaDataService = metaDataService;
            this.accountsService = customerServices;
            this.userManager = userManager;
            this.customerService = customerService;
            this.paymentsService = paymentsService;
            this.requestsService = requestsService;
        }

        public IActionResult RequestLoan()
        {
            var request = new Request();
            var customer = customerService.GetCustomerFromUserId(userManager.GetUserId(User));
            request.Type = "Loan";
            request.SendDate = DateTime.Now;
            request.Status = 0;
            request.Customer = customer;
            requestsService.AddRequest(request);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RequestCard()
        {
            var request = new Request();
            var customer = customerService.GetCustomerFromUserId(userManager.GetUserId(User));
            request.Type = "Card";
            request.SendDate = DateTime.Now;
            request.Status = 0;
            request.Customer = customer;
            requestsService.AddRequest(request);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Index()
        {
            string userId = userManager.GetUserId(User);
            try
            {
                var customer = customerService.GetCustomerFromUserId(userId);
                List<BankAccountViewModel> accountViewApplicationLogic = new List<BankAccountViewModel>();

                foreach (var bankAccount in customer.BankAccounts)
                {
                    accountViewApplicationLogic.Add(new BankAccountViewModel
                    {
                        BankAccount = bankAccount
                    });
                }
                AccountsListViewModel viewModel = new AccountsListViewModel()
                {
                    BankAccounts = accountViewApplicationLogic,
                    CustomerName = $"{customer.FirstName} {customer.LastName}",
                    PhoneNo = customer.ContactDetails?.PhoneNo
                };

                return View(viewModel);
            }
            catch (Exception e)
            {
                //log exception
                return BadRequest("Unable retrieve data for the current user");
            }
        }

        public IActionResult Details([FromRoute] Guid id)
        {
            string userId = userManager.GetUserId(User);
            try
            {
                var customer = customerService.GetCustomerFromUserId(userId);
                var bankAccount = accountsService.GetCustomerBankAccount(userId, id);
                var viewModel = new BankAccountViewModel
                {
                    CustomerName = $"{customer.FirstName} {customer.LastName}",
                    CustomerContact = customer.ContactDetails?.PhoneNo,
                    BankAccount = bankAccount
                };
                return View(viewModel);
            }
            catch (Exception)
            {

                return BadRequest("Unable to process your request");
            }
        }
        [HttpGet]

        public IActionResult Transactions([FromRoute] Guid accountId, [FromQuery] string searchString)
        {

            string userId = userManager.GetUserId(User);
            try
            {
                var customer = customerService.GetCustomerFromUserId(userId);
                
                //var bankaccount = accountsService.
                var transactions = customer.GetFilteredAccountTransactions(customer.Id, searchString);
                var partialResult = PartialView("_TransactionsPartial", transactions);
                return partialResult;
            }
            catch (Exception e)
            {
                return BadRequest("Unable to process your request");
            }
        }


        public IActionResult TransactionsReport([FromRoute] Guid accountId, [FromQuery] string searchString)
        {

            string userId = userManager.GetUserId(User);
            try
            {
                var customer = customerService.GetCustomerFromUserId(userId);
                var transactions = accountsService.GetFilteredAccountTransactions(userId, accountId, searchString);
                var account = accountsService.GetCustomerBankAccount(userId, accountId);
                var reportViewModel = new TransactionsReportViewModel
                {
                    CustomerName = $"{customer.FirstName} {customer.LastName}",
                    Account = account.IBAN,
                    Currency = account.Currency,
                    Transactions = transactions,
                    Balance = account.Balance

                };
                var fileName = $"TrRep_{DateTime.UtcNow.ToShortDateString()}_{account.IBAN}.pdf";
                fileName = fileName.Replace('/', '_');
                fileName = fileName.Replace('\\', '_');
                fileName = fileName.Replace(':', '_');

                return PartialView("_TransactionsPartial", transactions);
            }
            catch (Exception e)
            {
                return BadRequest("Unable to process your request");
            }
        }

        [HttpGet]
        public IActionResult NewPayment(string accountId)
        {
            var accountGuid = Guid.Empty;
            Guid.TryParse(accountId, out accountGuid);
            return PartialView("_NewPaymentPartial", new NewPaymentViewModel { SourceAccount = accountGuid, PaymentStatus = NewPaymentStatus.NotInitiated });
        }

        [HttpPost]
        public IActionResult NewPayment([FromForm] NewPaymentViewModel paymentData)
        {
            NewPaymentViewModel viewModelResult = new NewPaymentViewModel()
            {
                PaymentStatus = NewPaymentStatus.Failed
            };
            if (!ModelState.IsValid ||
                paymentData == null ||
                paymentData.SourceAccount == null ||
                paymentData.Amount == null
                )
                return PartialView("_NewPaymentPartial", viewModelResult);

            ModelState.Clear();
            try
            {
                var userId = userManager.GetUserId(User);
                paymentsService.CreateAccountPayment(userId,
                                                      paymentData.SourceAccount.Value,
                                                      paymentData.Amount.Value,
                                                      paymentData.DestinationName,
                                                      paymentData.DestinationIBAN,
                                                      paymentData.Details);

                viewModelResult.PaymentMessage = "Done";
                viewModelResult.PaymentStatus = NewPaymentStatus.Created;
            }
            catch (NotEnoughFundsException)
            {
                viewModelResult.PaymentStatus = NewPaymentStatus.Failed;
                viewModelResult.PaymentMessage = "Not enough funds available";
            }
            catch (WrongCurrencyException)
            {
                viewModelResult.PaymentStatus = NewPaymentStatus.Failed;
                viewModelResult.PaymentMessage = "Payments not allowed for accounts with different currency";
            }
            catch (Exception e)
            {
                viewModelResult.PaymentStatus = NewPaymentStatus.Failed;
                viewModelResult.PaymentMessage = "Unexpected error occured";
            }

            return PartialView("_NewPaymentPartial", viewModelResult);
        }

        [HttpGet]
        public IActionResult AccountBalance([FromRoute] Guid accountId)
        {
            var userId = userManager.GetUserId(User);
            try
            {
                var bankAccount = accountsService.GetCustomerBankAccount(userId, accountId);
                return PartialView("_AccountBalancePartial", bankAccount);
            }
            catch (Exception)
            {
                return PartialView("_AccountBalancePartial");
            }
        }

    }
}
