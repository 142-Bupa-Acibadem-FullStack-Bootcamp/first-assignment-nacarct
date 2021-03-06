using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Concrete.EntityFramework.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context, DbSet<Employee> dbSet) : base(context, dbSet)
        {
            //Constructor
        }

        public IQueryable EmployeeReport()
        {
            return _dbSet.AsQueryable();
        }
    }
}