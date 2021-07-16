using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Infrastructure.Migrations
{
    public partial class password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 16, 11, 17, 52, 227, DateTimeKind.Local).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 16, 11, 10, 15, 181, DateTimeKind.Local).AddTicks(2811));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 16, 11, 10, 15, 181, DateTimeKind.Local).AddTicks(2811),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 16, 11, 17, 52, 227, DateTimeKind.Local).AddTicks(2342));
        }
    }
}
