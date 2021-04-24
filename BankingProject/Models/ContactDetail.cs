using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingProject.Models
{
    public class ContactDetail
    {
        public int ContactDetailId { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string AlternatePhoneNo { get; set; }
        public string Email { get; set; }
        public ICollection<Costumer> Costumers { get; set; }
    }
}
