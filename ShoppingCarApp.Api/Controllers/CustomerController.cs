using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCarApp.Api.Controllers.General;
using ShoppingCarApp.Bussines.Dtos;
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
    public class CustomerController : BaseController<Customer, CustomerDto, IBaseService<Customer>>
    {
        public CustomerController(IBaseService<Customer> manager, IMapper Mapper) : base(manager, Mapper)
        {

        }
    }
}