using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.MultiTenant.Data;

namespace WebApi.MultiTenant.Controllers
{
   public class CostumersController : Controller
   {
      [HttpGet("/Costumers")]
      public async Task<IActionResult> Index([FromServices] MasterDataContext context)
      {
         return Ok(await context.Customers.ToListAsync());
      }
   }
}
