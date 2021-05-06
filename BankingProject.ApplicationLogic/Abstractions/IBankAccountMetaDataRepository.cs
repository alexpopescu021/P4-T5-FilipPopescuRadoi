﻿using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface IBankAccountMetaDataRepository : IBaseRepository<BankAccountMetaData>
    {
        BankAccountMetaData GetMetadataForBankAccount(Guid bankAccountId);
    }
}
