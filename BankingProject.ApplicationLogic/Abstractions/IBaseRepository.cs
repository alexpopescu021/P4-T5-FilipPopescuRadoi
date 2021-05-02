using BankingProject.ApplicationLogic.Model;
using System;
using System.Collections.Generic;

namespace BankingProject.ApplicationLogic.Abstractions
{
    public interface IBaseRepository<T> where T : DataEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        T Add(T entity);
        T Update(T entity);
        bool Remove(Guid id);
    }
}
