using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Type { get; set; }
        public DateTime SendDate { get; set; }
        public Costumer Costumer { get; set; }
    }
}
