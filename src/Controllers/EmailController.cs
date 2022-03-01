using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.MultiTenant.Data;

namespace WebApi.MultiTenant.Controllers
{
   public class EmailController : Controller
   {
      [HttpGet("/{clientName}/emails")]
      public async Task<IActionResult> GetContacts([FromServices] CustomerDataContext context)
      {
         var contacts = await context.Emails.ToListAsync();
         return Ok(contacts);
      }
   }
}
