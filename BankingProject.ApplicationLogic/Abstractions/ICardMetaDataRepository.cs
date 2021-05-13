using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface ICardMetaDataRepository : IBaseRepository<CardMetaData>
    {
        CardMetaData GetMetaData(Guid cardId);
    }
}
