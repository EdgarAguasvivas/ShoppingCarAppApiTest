using ShoppingCarApp.Bussines.Service.General;
using ShoppingCarApp.Custom.Filters.Base;
using ShoppingCarApp.Custom.Pagination;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Concrete.General
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseClass, new()
    {
        protected readonly IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public virtual Guid Create(T entity)
        {
            try
            {
                return _repository.Create(entity);
            }
            catch (Exception e)
            {

                throw new ArgumentException(e.Message);
            }

        }

        public virtual void Delete(Guid Id)
        {
            try
            {
                _repository.Delete(Id);
            }
            catch (Exception e)
            {

                throw new ArgumentException(e.Message);
            }
        }

        public virtual IQueryable<T> FindAll()
        {
            return _repository.FindAll();
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _repository.FindByCondition(expression);
        }

        public virtual T GetOne(Guid Id)
        {
            return _repository.GetOne(Id);
        }

        public virtual T Update(T entity)
        {
            return _repository.Update(entity);
        }
        public virtual void AddRange(List<T> entity)
        {
            _repository.AddRange(entity);
        }
        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return _repository.Exist(expression);
        }

        public PagedData<T> GetPaged(BaseFilter filter, IQueryable<T> List)
        {
            return _repository.GetPaged(filter, List);
        }
    }
}