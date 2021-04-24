using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        public float Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float LunarFee { get; set; }
        public Costumer Costumer { get; set; }
    }
}
