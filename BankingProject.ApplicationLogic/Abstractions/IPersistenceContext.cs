using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface IPersistenceContext : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        ICardRepository CardRepository { get; }
        TransactionScope BeginTransaction();
        void SaveChanges();
    }
}
