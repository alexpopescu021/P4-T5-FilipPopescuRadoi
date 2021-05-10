﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public class Card : DataEntity
    {

        public string SerialNumber { get; set; }
        public int CVV { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string OwnerName { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public virtual ICollection<CardTransaction> CardTransactions { get; set; }
    }
}
