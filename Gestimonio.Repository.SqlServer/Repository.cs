﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gestimonio.Repository.SqlServer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly gestimonio2Context _dbContext;

        public Repository(gestimonio2Context dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(T entity)
        {
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }

        public bool Delete(T entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public T GetById(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public IEnumerable<T> GetList()
        {
            return _dbContext.Set<T>();
        }

        public bool Update(T entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
