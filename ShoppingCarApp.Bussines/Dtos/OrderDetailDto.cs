using ShoppingCarApp.Bussines.Dtos.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Dtos
{
    public class OrderDetailDto : BaseClassDto
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }
        public ProductDto Product { get; set; }
    }
}
