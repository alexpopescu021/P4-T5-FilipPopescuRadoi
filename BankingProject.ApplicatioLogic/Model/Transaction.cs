using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Model
{
    public class Transaction : DataEntity
    {

        public string ExternalIBAN { get; set; }
        public string ExternalName { get; set; }
        public float Amount { get; set; }
        public DateTime Time { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
