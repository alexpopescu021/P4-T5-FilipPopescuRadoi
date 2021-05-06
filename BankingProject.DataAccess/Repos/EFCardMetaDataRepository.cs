using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using System.Linq;

namespace BankingProject.DataAccess.Repos
{
    public class EFCardMetaDataRepository : EFBaseRepository<CardMetaData>, ICardMetaDataRepository
    {
        public EFCardMetaDataRepository(BankingDbContext dbContext) : base(dbContext)
        {

        }
        public CardMetaData GetMetaData(Guid cardId)
        {
            var color = dbContext.CardMetaData.Where(cardColor => cardColor.CardId == cardId).FirstOrDefault();
            return color;
        }
    }
}
