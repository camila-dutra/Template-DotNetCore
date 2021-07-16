using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Infrastructure.Migrations
{
    public partial class passwordfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 16, 11, 10, 15, 181, DateTimeKind.Local).AddTicks(2811),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 14, 16, 6, 34, 372, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext",
                nullable: false,
                defaultValue: "Teste")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 14, 16, 6, 34, 372, DateTimeKind.Local).AddTicks(96),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 16, 11, 10, 15, 181, DateTimeKind.Local).AddTicks(2811));
        }
    }
}
