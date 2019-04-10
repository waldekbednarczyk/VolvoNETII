using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VolvoNETII.DataAccess.Repositories
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T> where T : class where C : DbContext
    {

        private readonly C _context;

        protected GenericRepository(C context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public virtual async void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
