using ShoppingCarApp.Bussines.Service.Concrete.General;
using ShoppingCarApp.Custom.Constant;
using ShoppingCarApp.Custom.Exceptions;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Concrete
{
    public class ProductService : BaseService<Product>
    {

        public ProductService(IBaseRepository<Product> repository) : base(repository)
        {

        }
        private void Validate(Product entity)
        {
            if (base.Exist(c => c.Name == entity.Name))
                throw new DuplicateValueException(Message.MessageDuplicateProduct);
        }
        public override Guid Create(Product entity)
        {
            this.Validate(entity);
            return base.Create(entity);
        }
    }
}
