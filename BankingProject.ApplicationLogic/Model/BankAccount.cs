
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Model
{
    public class BankAccount : DataEntity
    {
        public string IBAN { get; set; }
        public float Balance { get; set; }
        public string Currency { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public ICollection<Card> Cards { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
