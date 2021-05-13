using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingProject.ApplicationLogic.Model;
using BankingProject.ApplicationLogic.Abstractions;

namespace BankingProject.DataAccess.Repos
{
    public class EFRequestRepository : EFBaseRepository<Request>, IRequestRepository
    {
        public EFRequestRepository(BankingDbContext dbContext) : base(dbContext)
        { }

        public IEnumerable<Request> GetByCustomerId(Guid id)
        {
            return dbContext.Requests.Where(s => s.Customer.Id.Equals(id)).AsEnumerable();
        }
    }
}
