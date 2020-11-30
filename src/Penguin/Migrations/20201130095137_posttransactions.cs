using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Penguin.Migrations
{
    public partial class posttransactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountNumber = table.Column<string>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false),
                    centsAmount = table.Column<int>(nullable: false),
                    currencyCode = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    reference = table.Column<string>(nullable: true),
                    cardId = table.Column<string>(nullable: true),
                    merchantName = table.Column<string>(nullable: true),
                    merchantCity = table.Column<string>(nullable: true),
                    categoryCode = table.Column<string>(nullable: true),
                    categoryKey = table.Column<string>(nullable: true),
                    categoryName = table.Column<string>(nullable: true),
                    countryCode = table.Column<string>(nullable: true),
                    countryAlpha3 = table.Column<string>(nullable: true),
                    countryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTransactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTransactions");
        }
    }
}
