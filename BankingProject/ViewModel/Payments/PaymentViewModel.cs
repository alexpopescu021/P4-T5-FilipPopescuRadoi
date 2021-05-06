using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ViewModel.Payments
{
    public class PaymentsViewModel
    {
        public IEnumerable<BankAccount> BanksAccounts { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNo { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}
