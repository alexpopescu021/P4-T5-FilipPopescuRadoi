using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ViewModel.Received
{
    public class ReceivedListViewModel
    {
        public IEnumerable<BankAccount> BankAccounts { get; set; }
        //public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Transaction> Received { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public int IsSelected { get; set; }
    }
}
