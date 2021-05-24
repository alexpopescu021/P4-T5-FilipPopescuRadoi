using System;
using System.Collections.Generic;
using System.Text;

namespace MoqRepositorySample
{
    using BankingProject.ApplicationLogic.Model;
    using System.Collections.Generic;

    public interface IBaseRepository
    {
        IList<Transaction> FindAll();

        Transaction FindByName(string productName);

        Transaction FindById(int productId);

        bool Save(Transaction target);
    }
}
