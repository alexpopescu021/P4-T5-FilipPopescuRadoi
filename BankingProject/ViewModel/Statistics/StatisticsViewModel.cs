using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ViewModel.Statistics
{
    public class StatisticsViewModel
    {
        public IEnumerable<BankAccountStatisticsViewModel> BankAccounts { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNo { get; set; }
        public IEnumerable<int> TransactionIndexes { get; set; }
    }
}
