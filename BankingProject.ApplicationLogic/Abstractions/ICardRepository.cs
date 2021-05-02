using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface ICardRepository : IBaseRepository<Card>
    {

        IEnumerable<Card> GetByAccountId(Guid userId);
        void AddCardTransaction(Card card);

    }
}
