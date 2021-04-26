﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string SerialNumber { get; set; }
        public int CVV { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string OwnerName { get; set; }
        public BankAccount BankAccount { get; set; }
        public ICollection<CardTransaction> CardTransactions { get; set; }
    }
}
