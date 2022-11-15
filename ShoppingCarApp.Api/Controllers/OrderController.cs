using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCarApp.Api.Controllers.General;
using ShoppingCarApp.Bussines.Dtos;
using ShoppingCarApp.Bussines.Service.Abstract;
using ShoppingCarApp.Bussines.Service.General;
using ShoppingCarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCarApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController<Order, OrderDto, IBaseService<Order>>
    {
        private readonly IOrder order;
        public OrderController(IOrder order, IBaseService<Order> manager, IMapper Mapper) : base(manager, Mapper)
        {
            this.order = order;
        }
        [HttpGet]
        [Route("GetCurrentOrder")]
        public IActionResult GetCurrentOrder(Guid customer)
        {

            return Ok(this.order.GetCurrentOrder(customer));
        }

    }
}