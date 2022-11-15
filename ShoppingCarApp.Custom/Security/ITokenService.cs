using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Custom.Security
{
    public interface ITokenService
    {
        string GetCurrentUser();
    }
}
