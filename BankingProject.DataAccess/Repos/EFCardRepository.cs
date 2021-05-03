using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.DataAccess.Repos
{
    public class EFCardRepository : EFBaseRepository<Card>, ICardRepository
    {

        public EFCardRepository(BankingDbContext dbContext) : base(dbContext)
        {

        }
        public IEnumerable<Card> GetByAccountId(Guid accountId)
        {
            var cardList = dbContext.Cards
                                    .Where(card => card.BankAccount.Id == accountId);
            return cardList;
        }
        public void AddCardTransaction(Card card)
        {
            dbContext.Cards.Update(card);
            dbContext.SaveChanges();
        }


    }
}
