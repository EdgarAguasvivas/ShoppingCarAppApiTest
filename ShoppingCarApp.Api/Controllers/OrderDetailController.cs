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
    public class OrderDetailController : BaseController<OrderDetail, OrderDetailDto, IBaseService<OrderDetail>>
    {
        private readonly IOrderDetail orderDetail;
        public OrderDetailController(IOrderDetail orderDetail, IBaseService<OrderDetail> manager, IMapper Mapper) : base(manager, Mapper)
        {
            this.orderDetail = orderDetail;
        }
        [HttpGet]
        [Route("GetDetailByOrder")]
        public IActionResult GetDetailByOrder(Guid order)
        {

            return Ok(this.orderDetail.GetByOrder(order));
        }
    }
}