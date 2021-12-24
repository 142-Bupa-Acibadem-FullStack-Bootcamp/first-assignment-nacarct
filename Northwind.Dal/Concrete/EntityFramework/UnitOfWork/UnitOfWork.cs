using Northwind.Dal.Abstract;

namespace Northwind.Dal.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public bool RollBackTransaction()
        {
            throw new System.NotImplementedException();
        }

        public int SaveChange()
        {
            throw new System.NotImplementedException();
        }
    }
}