using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public Customer GetCustomerFromUserId(string userId)
        {
            Guid idToSearch = Guid.Parse(userId);
            var customer = customerRepository?.GetCustomerByUserId(idToSearch);
            if (customer == null)
            {
                throw new Exception();
            }

            return customer;
        }
    }
}
