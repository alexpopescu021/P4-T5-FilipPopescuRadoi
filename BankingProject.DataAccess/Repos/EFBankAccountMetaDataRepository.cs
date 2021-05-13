using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;
using System.Linq;

namespace BankingProject.DataAccess.Repos
{
    public class EFBankAccountMetaDataRepository : EFBaseRepository<BankAccountMetaData>, IBankAccountMetaDataRepository
    {
        public EFBankAccountMetaDataRepository(BankingDbContext context) : base(context)
        {
        }
        public BankAccountMetaData GetMetadataForBankAccount(Guid bankAccountId)
        {
            return dbContext.BankAccountMetaDatas
                    .Where(metaData => metaData.BankAccountId == bankAccountId)
                    .FirstOrDefault();
        }
    }
}
