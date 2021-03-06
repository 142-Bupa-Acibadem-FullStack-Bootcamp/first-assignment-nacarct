using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class SalesTotalsByAmountRepository : GenericRepository<SalesTotalsByAmount>, ISalesTotalsByAmountRepository
    {
        public SalesTotalsByAmountRepository(DbContext context, DbSet<SalesTotalsByAmount> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable SalesTotalsByAmountReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}