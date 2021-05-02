using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Model
{
    public class Request : DataEntity
    {
        public string Type { get; set; }
        public DateTime SendDate { get; set; }
        public Customer Costumer { get; set; }
    }
}
