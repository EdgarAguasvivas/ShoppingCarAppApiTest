using ShoppingCarApp.Custom.Filters.Base;
using ShoppingCarApp.Custom.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.General
{
    public interface IBaseService<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        bool Exist(Expression<Func<T, bool>> expression);
        T GetOne(Guid Id);
        Guid Create(T entity);
        T Update(T entity);
        void AddRange(List<T> entity);
        void Delete(Guid Id);
        PagedData<T> GetPaged(BaseFilter filter, IQueryable<T> List);
    }
}