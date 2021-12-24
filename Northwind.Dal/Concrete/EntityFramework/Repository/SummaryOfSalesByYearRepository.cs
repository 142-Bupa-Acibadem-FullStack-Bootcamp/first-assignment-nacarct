﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class SummaryOfSalesByYearRepository : GenericRepository<SummaryOfSalesByYear>, ISummaryOfSalesByYearRepository
    {
        public SummaryOfSalesByYearRepository(DbContext context, DbSet<SummaryOfSalesByYear> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable SummaryOfSalesByYearReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}