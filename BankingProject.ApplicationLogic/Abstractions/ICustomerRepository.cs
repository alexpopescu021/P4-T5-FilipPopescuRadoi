using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Customer GetCustomerByUserId(Guid userId);

        IEnumerable<Customer> FindByLastName(string lastName);

        Customer UpdateCustomerDetails(Guid customerId, Customer customerDetails);
        IEnumerable<Customer> GetCustomerstWithBankAccounts();

        Customer GetCustomerThatOwnsIban(string iban);

        IEnumerable<Customer> GetCustomers();

        void AddBankAccount(BankAccount account);

    }
}
