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
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(ShoppingCarAppContext ctx) : base(ctx)
        {

        }
    }
}
