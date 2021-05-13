﻿using System;
using System.Collections.Generic;
using System.Text;
using BankingProject.ApplicationLogic.Model;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface IRequestRepository : IBaseRepository<Request>
    {
        public IEnumerable<Request> GetByCustomerId(Guid id);
    }
}
