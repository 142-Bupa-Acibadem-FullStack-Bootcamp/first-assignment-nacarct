using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Northwind.Entity.IBase;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T:IEntityBase where TDto:IDtoBase
    {
        List<TDto> GetAll();
        List<TDto> GetAll(Expression<Func<T, bool>> expression);
        TDto Find(int id);
        IQueryable<T> GetQueryable();
        TDto Add(TDto entity);
        Task<TDto> AddAsync(TDto entity);
        TDto Update(TDto entity);
        Task<TDto> UpdateAsync(TDto entity);
        bool DeleteById(int id);
        Task<bool> DeleteByIdAsync(int id);
        bool Delete(TDto entity);
        Task<bool> DeleteAsync(TDto entity);
    }
}