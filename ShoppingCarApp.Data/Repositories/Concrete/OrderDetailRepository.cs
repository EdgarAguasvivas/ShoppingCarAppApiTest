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
    public class OrderDetailRepository : BaseRepository<OrderDetail>
    {
        public OrderDetailRepository(ShoppingCarAppContext ctx) : base(ctx)
        {

        }
        public override IQueryable<OrderDetail> FindAll()
        {
            return base.FindAll().Include(c => c.Product);
        }
    }
}
