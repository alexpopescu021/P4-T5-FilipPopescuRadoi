﻿using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingProject.DataAccess.Repos
{
    public class EFCustomerRepository : EFBaseRepository<Customer>, ICustomerRepository
    {

        public EFCustomerRepository(BankingDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Customer> FindByLastName(string lastName)
        {
            var customersList = dbContext.Customers
                                .Where(customer =>
                                            customer.LastName
                                            .ToLower()
                                            .Contains(lastName.ToLower()));

            return customersList.AsEnumerable();
        }

        public IEnumerable<Customer> GetCustomerstWithBankAccounts()
        {
            return dbContext.Customers
                                .Where(customer =>
                                customer.BankAccounts.Count() > 0);
        }


        public Customer GetCustomerByUserId(Guid userId)
        {
            var foundCustomer = dbContext.Customers
                                /* .Include(c => c.ContactDetails)
                                 .Include(c => c.BankAccounts)
                                 .Include(c => c.BankAccounts.Select(ba => ba.Transactions))*/
                                .Where(customer => customer.UserId == userId)
                                .FirstOrDefault();
            return foundCustomer;
        }

        public Customer UpdateCustomerDetails(Guid customerId, Customer customerDetails)
        {
            var customerEntity = dbContext.Update(customerDetails);
            dbContext.SaveChanges();
            return customerEntity.Entity;
        }

        public Customer GetCustomerThatOwnsIban(string iban)
        {
            var bankAccount = dbContext.BankAccounts
                                        .Where(ba => ba.IBAN.Equals(iban))
                                        .FirstOrDefault();
            Customer customer = null;

            if (bankAccount != null)
            {

                customer = dbContext.Customers.Where(c => c.BankAccounts
                                                           .Where(ba => ba.Id == bankAccount.Id)
                                                           .Count() > 0)
                                              .FirstOrDefault();
            }
            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return dbContext.Customers.AsEnumerable();
        }
        public bool Remove(Guid id)
        {
            var customer = GetById(id);
            dbContext.Remove(customer);
            dbContext.SaveChanges();
            return true;
        }
    }
}
