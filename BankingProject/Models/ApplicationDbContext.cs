using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.Models;

namespace BankingProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardTransaction> CardTransactions { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
