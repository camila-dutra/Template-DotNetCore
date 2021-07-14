using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Infrastructure.Migrations
{
    public partial class IsDeletedfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 14, 16, 6, 34, 372, DateTimeKind.Local).AddTicks(96),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 13, 15, 54, 24, 64, DateTimeKind.Local).AddTicks(3426));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 13, 15, 54, 24, 64, DateTimeKind.Local).AddTicks(3426),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 14, 16, 6, 34, 372, DateTimeKind.Local).AddTicks(96));
        }
    }
}
