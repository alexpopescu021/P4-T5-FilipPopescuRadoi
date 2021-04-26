
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Model
{
    public class Loan : DataEntity
    {
        public float Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float LunarFee { get; set; }
        public Customer Costumer { get; set; }
    }
}
