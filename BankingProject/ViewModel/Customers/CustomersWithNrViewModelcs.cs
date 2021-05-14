using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ViewModel.Customers
{
    public class CustomersWithNrViewModelcs
    {
        public IEnumerable<Customer> Customers { get; set; }
        public int CustomersNumber { get; set; }
    }
}
