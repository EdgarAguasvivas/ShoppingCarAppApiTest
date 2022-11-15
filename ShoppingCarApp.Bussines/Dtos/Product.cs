using ShoppingCarApp.Bussines.Dtos.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Dtos
{
    public class ProductDto : BaseClassDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }

    }
}
