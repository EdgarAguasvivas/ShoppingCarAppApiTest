using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCarApp.Bussines.Profiles;
using ShoppingCarApp.Bussines.Service.Abstract;
using ShoppingCarApp.Bussines.Service.Concrete;
using ShoppingCarApp.Bussines.Service.General;
using ShoppingCarApp.Domain.Entities;

namespace ShoppingCarApp.Bussines.Configuration
{
    public static partial class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Customer>, CustomerService>();
            services.AddScoped<IBaseService<Product>, ProductService>();
            services.AddScoped<IBaseService<OrderDetail>, OrderDetailService>();
            services.AddScoped<IBaseService<Order>, OrderService>();
            services.AddScoped<IAccount, AccountService>();
            services.AddScoped<IOrder, OrderService>();
            services.AddScoped<IOrderDetail, OrderDetailService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CutomerProfile());
                mc.AddProfile(new ProductProfile());
                mc.AddProfile(new OrderDetailProfile());
                mc.AddProfile(new OrderProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();
        }
    }
}
