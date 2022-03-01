using Microsoft.EntityFrameworkCore;
using WebApi.MultiTenant.Models;

namespace WebApi.MultiTenant.Data
{
   public class CustomerDataContext : DbContext
   {
      public CustomerDataContext(DbContextOptions<CustomerDataContext> options) : base(options)
      {

      }

      public CustomerDataContext()
      {

      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         //string de conexão generica, e se faz necessario para que as migrações possam ser criadas
         if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseNpgsql("Server=192.168.3.6;Port=5432;Database=MultiTenant_ABC_POC;Userid=postgres;Password=PASSWORD;Pooling=true;MinPoolSize=5;MaxPoolSize=20;ApplicationName=MultiTenant_ABC_POC");
      }

      public DbSet<Contact> Contacts { get; set; }
      public DbSet<Email> Emails { get; set; }
      public DbSet<Telefone> Telefones { get; set; }
      public DbSet<Municipio> Municipios { get; set; }
   }
}
