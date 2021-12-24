﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DbContext context, DbSet<Supplier> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable SupplierReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}