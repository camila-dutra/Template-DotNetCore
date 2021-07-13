using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Infrastructure.Migrations
{
    public partial class Isertingnewuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("42e5f94c-6c88-472c-bfd5-00e79e0aa640"), "joao@template.com", "Joao da Silva" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("42e5f94c-6c88-472c-bfd5-00e79e0aa640"));
        }
    }
}
