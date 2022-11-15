using ShoppingCarApp.Bussines.Dtos.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Dtos
{
    public class OrderDto : BaseClassDto
    {
        public Guid CustomerId { get; set; }
        public bool Invoiced { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalItems { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
