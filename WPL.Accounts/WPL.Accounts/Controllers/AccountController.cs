using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WPL.Accounts.Services;

namespace WPL.Accounts.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IOrderService _orderService;

        public AccountController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string address)
        {
            try
            {
                return Ok(new
                {
                    AccountId = Guid.NewGuid(),
                    Orders = await _orderService.GeOrders(address)
                });
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e);
            }

        }
    }
}
