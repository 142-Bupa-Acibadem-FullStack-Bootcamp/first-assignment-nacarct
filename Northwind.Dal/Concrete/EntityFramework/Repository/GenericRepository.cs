using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T:EntityBase
    {
        #region Variables

        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        #endregion

        #region Constructor

        public GenericRepository(DbContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        #endregion

        #region Methods

        public T Add(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _dbSet.Add(entity);
            return entity;
        }

        public T Update(T entity)
        { 
            _dbSet.Update(entity);
            return entity;
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public bool Delete(int id)
        {
            return Delete(Find(id));
        }

        public bool Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _context.Attach(entity);
            }

            return _dbSet.Remove(entity)!=null;
        }

        #endregion


    }
}