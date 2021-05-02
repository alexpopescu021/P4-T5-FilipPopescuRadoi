using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Model
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
