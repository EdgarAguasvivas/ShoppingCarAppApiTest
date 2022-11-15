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
    public class CustomerService : BaseService<Customer>
    {
        public CustomerService(IBaseRepository<Customer> repository) : base(repository)
        {
        }
        private void Validate(Customer entity)
        {

            if (base.Exist(c => c.DocumentNumber == entity.DocumentNumber))
                throw new DuplicateValueException(Message.MessageDuplicateCustomerDocument);
            if (base.Exist(c => c.Email == entity.Email))
                throw new DuplicateValueException(Message.MessageDuplicateEmail);
        }
        public override Guid Create(Customer entity)
        {
            this.Validate(entity);            
            return base.Create(entity);
        }
    }
}