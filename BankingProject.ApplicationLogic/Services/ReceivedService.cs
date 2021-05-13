using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;
using System.Linq;

namespace BankingProject.ApplicationLogic.Services
{
    public class ReceivedService
    {
        private CustomerService customerService;

        public ReceivedService(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IEnumerable<Transaction> GetCustomerTransaction(string userId)
        {
            var customer = customerService.GetCustomerFromUserId(userId);
            var receivedList = new List<Transaction>();
            foreach (var account in customer.BankAccounts)
            {
                foreach (var transaction in account.Transactions)
                {
                    if (transaction.Amount > 0)
                    {
                        receivedList.Add(transaction);
                    }
                }
            }
            return receivedList.AsEnumerable();
        }

    }
}
