using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ViewModel.Statistics
{
    public class BankAccountStatisticsViewModel
    {
        public BankAccount BankAccount { get; set; }
        public BankAccountMetaData MetaData { get; set; }
        public IEnumerable<decimal> BalanceHistory { get; set; }
    }
}
