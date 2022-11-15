using ShoppingCarApp.Domain.Entities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Domain.Entities
{
    public class Order : BaseClass
    {
        public Guid CustomerId { get; set; }
        public bool Invoiced { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalItems { get; set; }
        public Customer Customer { get; set; }
    }
}