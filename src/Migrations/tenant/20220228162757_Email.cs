using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.MultiTenant.migrations.tenant
{
   public partial class Email : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.CreateTable(
             name: "Emails",
             columns: table => new
             {
                Id = table.Column<Guid>(nullable: false),
                Endereco = table.Column<string>(nullable: true)
             },
             constraints: table =>
             {
                table.PrimaryKey("PK_Emails", x => x.Id);
             });

         migrationBuilder.InsertData("Emails", new[]
            {
                  "Id", "Endereco"
               },
            new[]
            {
                  Guid.NewGuid(),
                  (object)"Endereco de email (1)"
            }, "public");
         migrationBuilder.InsertData("Emails", new[]
            {
               "Id", "Endereco"
            },
            new[]
            {
               Guid.NewGuid(),
               (object)"Endereco de email (2)"
            }, "public");
         migrationBuilder.InsertData("Emails", new[]
            {
               "Id", "Endereco"
            },
            new[]
            {
               Guid.NewGuid(),
               (object)"Endereco de email (3)"
            }, "public");
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropTable(
             name: "Emails");
      }
   }
}
