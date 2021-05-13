using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ViewModel.Accounts
{
    public class AccountsListViewModel
    {
        public IEnumerable<BankAccountViewModel> BankAccounts { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
    }
}
