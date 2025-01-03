using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyServer.Migrations
{
    /// <inheritdoc />
    public partial class AddPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1f897ac8-76a8-4d87-b708-e70a8db0407b"));

            migrationBuilder.DropColumn(
                name: "Quality",
                table: "Components");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Supplies",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Components",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "JobTitle", "PersonId" },
                values: new object[] { new Guid("df3a9bd9-e8d5-4b3e-913f-641c8d611e7f"), "Admin", new Guid("00000000-0000-0000-0000-000000000001") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("df3a9bd9-e8d5-4b3e-913f-641c8d611e7f"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Supplies");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Components");

            migrationBuilder.AddColumn<string>(
                name: "Quality",
                table: "Components",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "JobTitle", "PersonId" },
                values: new object[] { new Guid("1f897ac8-76a8-4d87-b708-e70a8db0407b"), "Admin", new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
