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

        public CustomerService(IPersistenceContext persistenceContext)
        {
            customerRepository = persistenceContext.CustomerRepository;
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
        public IEnumerable<Customer> GetCustomers()
        {
            return customerRepository.GetCustomers();
        }

        public void RemoveCustomer(string id)
        {
            Guid idToSearch = Guid.Parse(id);
            customerRepository.Remove(idToSearch);
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.Update(customer);
        }
    }
}
