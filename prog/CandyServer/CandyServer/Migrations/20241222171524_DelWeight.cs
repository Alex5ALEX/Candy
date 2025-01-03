using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CandyServer.Migrations
{
    /// <inheritdoc />
    public partial class DelWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("df3a9bd9-e8d5-4b3e-913f-641c8d611e7f"));

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Candies");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "JobTitle", "PersonId" },
                values: new object[] { new Guid("1bdbb187-88d0-477c-bb57-5b11fc0cfbad"), "Admin", new Guid("00000000-0000-0000-0000-000000000001") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1bdbb187-88d0-477c-bb57-5b11fc0cfbad"));

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Candies",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "JobTitle", "PersonId" },
                values: new object[] { new Guid("df3a9bd9-e8d5-4b3e-913f-641c8d611e7f"), "Admin", new Guid("00000000-0000-0000-0000-000000000001") });
        }
    }
}
