﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Model
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
