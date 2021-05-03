
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.ApplicationLogic.Model
{
    public class Customer : DataEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialId { get; set; }
        public ContactDetail ContactDetail { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
        public ICollection<Request> Requests { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
