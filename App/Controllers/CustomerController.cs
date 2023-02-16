using BusinessLogic;
using DataAccess;
using DataAccess.FakeData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly Context _ctx;
        private readonly Fakers _fakers;

        public CustomerController(Context ctx, Fakers fakers)
        {
            _ctx = ctx;
            _fakers = fakers;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _ctx.Customers.Include(c => c.Address);
        }
    }
}
