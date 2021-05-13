using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingProject.ApplicationLogic.Services
{
    public class AccountsService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly CustomerService customerService;
        private readonly IPersistenceContext persistenceContext;

        public AccountsService(IPersistenceContext persistenceContext, CustomerService customerService)
        {

            this.persistenceContext = persistenceContext;
            customerRepository = persistenceContext.CustomerRepository;
            this.customerService = customerService;

        }

        public IEnumerable<BankAccount> GetCustomerBankAccounts(string userId)
        {
            var customer = customerService.GetCustomerFromUserId(userId);
            return customer.BankAccounts
                            .AsEnumerable();
        }

        public BankAccount GetCustomerBankAccount(string userId, Guid accountId)
        {
            var customer = customerService.GetCustomerFromUserId(userId);
            var account = customer.BankAccounts
                    .Where(ba => accountId.Equals(ba.Id))
                    .SingleOrDefault();
            if (account == null)
            {
               // throw new AccountNotFoundException(accountId);
            }

            return account;
        }

        public IEnumerable<Transaction> GetFilteredAccountTransactions(string userId, Guid accountId, string filter)
        {
            var customer = customerService.GetCustomerFromUserId(userId);
            return customer.GetFilteredAccountTransactions(accountId, filter);
        }
    }
}
