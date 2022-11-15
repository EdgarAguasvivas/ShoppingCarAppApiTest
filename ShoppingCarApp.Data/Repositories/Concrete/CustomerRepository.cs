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
    public class CustormerRepository : BaseRepository<Customer>
    {
        public CustormerRepository(ShoppingCarAppContext ctx) : base(ctx)
        {

        }

    }
}
