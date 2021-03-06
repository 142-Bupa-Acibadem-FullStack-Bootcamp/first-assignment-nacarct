using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class OrderDetailsExtendedRepository : GenericRepository<OrderDetailsExtended>, IOrderDetailsExtendedRepository
    {
        public OrderDetailsExtendedRepository(DbContext context, DbSet<OrderDetailsExtended> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable OrderDetailsExtendedReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}