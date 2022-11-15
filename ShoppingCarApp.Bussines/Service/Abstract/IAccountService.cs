using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Bussines.Service.Abstract
{
    public interface IAccount
    {
        Guid VerifyUser(string password, string userName);

    }
}