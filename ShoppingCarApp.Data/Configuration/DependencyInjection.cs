using Microsoft.Extensions.DependencyInjection;
using ShoppingCarApp.Data.Repositories.Concrete;
using ShoppingCarApp.Data.Repositories.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCarApp.Data.Configuration
{
    public static partial class DependensyInjectionConfiguration
    {
        public static void AddRespositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Customer>, CustormerRepository>();
            services.AddScoped<IBaseRepository<Product>, ProductRepository>();
            services.AddScoped<IBaseRepository<OrderDetail>, OrderDetailRepository>();
            services.AddScoped<IBaseRepository<Order>, OrderHeaderRepository>();

        }
    }
}
