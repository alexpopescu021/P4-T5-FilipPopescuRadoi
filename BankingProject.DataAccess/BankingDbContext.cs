using BankingProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProject.DataAccess
{
    public class BankingDbContext: DbContext
    {


        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardTransaction> CardTransactions { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Customer> Costumers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
