using ShoppingCarApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Domain.Entities
{
    public class OrderDetail : BaseClass
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
        public virtual Product Product { get; set; }
    }
}