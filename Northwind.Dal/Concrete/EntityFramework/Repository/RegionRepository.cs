﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbContext context, DbSet<Region> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable RegionReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}