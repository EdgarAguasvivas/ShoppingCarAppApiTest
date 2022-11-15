using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Abstract
{
    public interface IOrderDetail
    {
        IEnumerable<OrderDetail> GetByOrder(Guid Order);
    }
}