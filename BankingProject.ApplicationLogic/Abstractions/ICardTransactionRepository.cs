using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface ICardTransactionRepository : IBaseRepository<CardTransaction>
    {
        IEnumerable<CardTransaction> GetCardTransactions(IEnumerable<Transaction> transactions);


    }
}
