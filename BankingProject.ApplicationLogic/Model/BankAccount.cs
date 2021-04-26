using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string IBAN { get; set; }
        public float Balance { get; set; }
        public string Currency { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public Customer Costumer { get; set; }
        public ICollection<Card> Cards { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
