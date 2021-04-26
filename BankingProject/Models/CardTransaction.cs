using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class CardTransaction
    {
        public int CardTransactionId { get; set; }
        public string ExternalIBAN { get; set; }
        public string ExternalName { get; set; }
        public float Amount { get; set; }
        public DateTime Time { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public Card Card { get; set; }
    }
}
