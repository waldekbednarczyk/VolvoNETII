﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace VolvoNETII.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
    }
}