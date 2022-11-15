using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCarApp.Bussines.Service.Abstract;
using ShoppingCarApp.Custom.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCarApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        readonly IAccount accountService;
        public AccountController(IAccount accountService)
        {
            this.accountService = accountService;
        }
        [HttpPost]
        public IActionResult Login([FromBody] Account account)
        {

            try
            {
                var result = accountService.VerifyUser(account.Password, account.Email);
                return Ok(new { code = result });
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }

        }

    }
}