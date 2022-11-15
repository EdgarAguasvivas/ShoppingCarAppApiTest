using ShoppingCarApp.Bussines.Service.Abstract;
using ShoppingCarApp.Bussines.Service.Concrete.General;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Concrete
{
    public class AccountService : BaseService<Customer>, IAccount
    {

        public AccountService(IBaseRepository<Customer> repository) : base(repository)
        {

        }


        public Guid VerifyUser(string password, string userName)
        {
            var data = this._repository.FindByCondition(c => c.Password == password && c.Email == userName).FirstOrDefault();
            if (data == null)
                throw new ArgumentException("Cliente no existe");
            if (!data.IsActive)
                throw new ArgumentException("Cliente no esta activo");

            return data.Id;
        }
    }
}