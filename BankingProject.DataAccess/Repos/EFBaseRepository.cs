﻿
using BankingProject.DataAccess;
using BankingProject.DataAccess.Abstractions;
using BankingProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingProject.DataAccess.Repos
{
    public class EFBaseRepository<T> : IBaseRepository<T> where T : DataEntity
    {
        protected readonly BankingDbContext dbContext;

        public EFBaseRepository(BankingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Add(T itemToAdd)
        {
            var entity = dbContext.Add<T>(itemToAdd);
            dbContext.SaveChanges();
            return entity.Entity;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>()
                            .AsEnumerable();
        }

        public virtual T GetById(Guid id)
        {
            return dbContext.Set<T>()
                            .Where(entity => entity.Id.Equals(id))
                            .SingleOrDefault();
        }

        public bool Remove(Guid id)
        {
            var entityToRemove = GetById(id);
            if (entityToRemove != null)
            {
                dbContext.Remove<T>(entityToRemove);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public T Update(T itemToUpdate)
        {
            var entity = dbContext.Update<T>(itemToUpdate);
            dbContext.SaveChanges();
            return entity.Entity;
        }
    }
}
