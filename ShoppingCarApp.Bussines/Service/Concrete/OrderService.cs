using ShoppingCarApp.Bussines.Service.Abstract;
using ShoppingCarApp.Bussines.Service.Concrete.General;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Concrete
{
    public class OrderService : BaseService<Order>, IOrder
    {

        public OrderService(IBaseRepository<Order> repository) : base(repository)
        {

        }
        public override Guid Create(Order entity)
        {
            entity.Customer = null;
            entity.Invoiced = false;
            return base.Create(entity);
        }
        public Guid GetCurrentOrder(Guid customer)
        {
            var result = base.FindByCondition(c => c.CustomerId == customer && !c.Invoiced).FirstOrDefault();
            if (result is null)
                return base.Create(new Order { Invoiced = false, CustomerId = customer, Total = 0, TotalItems = 0, Customer = null });
            return result.Id;

        }
    }
}
