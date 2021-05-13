using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Abstractions;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.DataAccess.Repos
{
    public class EFLoanRepository : EFBaseRepository<Loan>, ILoanRepository
    {
        public EFLoanRepository(BankingDbContext dbContext) : base(dbContext)
        { }
    }
}
