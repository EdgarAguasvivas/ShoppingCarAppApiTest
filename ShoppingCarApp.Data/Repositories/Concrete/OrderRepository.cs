using Microsoft.EntityFrameworkCore;
using ShoppingCarApp.Data.Context;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Data.Repositories.Concrete
{
    public class OrderHeaderRepository : BaseRepository<Order>
    {
        public OrderHeaderRepository(ShoppingCarAppContext ctx) : base(ctx)
        {

        }
        public override IQueryable<Order> FindAll()
        {
            return base.FindAll().Include(v => v.Customer);
        }
    }
}
