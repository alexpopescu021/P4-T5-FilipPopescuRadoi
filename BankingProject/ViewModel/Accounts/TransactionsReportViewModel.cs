using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ViewModel.Accounts
{
    public class TransactionsReportViewModel
    {
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }
        public string Account { get; set; }
        public string Currency { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
