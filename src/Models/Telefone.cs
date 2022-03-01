using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.MultiTenant.Models
{
   public class Telefone
   {
      public Guid Id { get; set; }
      public string Numero { get; set; }
   }
}
