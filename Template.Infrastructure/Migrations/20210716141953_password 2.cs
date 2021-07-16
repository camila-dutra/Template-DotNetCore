using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Infrastructure.Migrations
{
    public partial class password2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext",
                nullable: false,
                defaultValue: "TESTETESTE",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValue: "Teste")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 16, 11, 19, 52, 718, DateTimeKind.Local).AddTicks(7944),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 16, 11, 17, 52, 227, DateTimeKind.Local).AddTicks(2342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext",
                nullable: false,
                defaultValue: "Teste",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValue: "TESTETESTE")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "User",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 16, 11, 17, 52, 227, DateTimeKind.Local).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 16, 11, 19, 52, 718, DateTimeKind.Local).AddTicks(7944));
        }
    }
}
