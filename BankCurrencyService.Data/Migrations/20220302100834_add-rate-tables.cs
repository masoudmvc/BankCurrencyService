using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCurrencyService.Data.Migrations
{
    public partial class addratetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExchangeRateResource",
                schema: "BCS",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApiKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceUri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    CreatorUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdaterKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdater = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    LastUpdaterUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRateResource", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRate",
                schema: "BCS",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceDeclaredUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeRateResourceKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatorKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    CreatorUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdaterKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdater = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    LastUpdaterUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRate", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ExchangeRate_ExchangeRateResource_ExchangeRateResourceKey",
                        column: x => x.ExchangeRateResourceKey,
                        principalSchema: "BCS",
                        principalTable: "ExchangeRateResource",
                        principalColumn: "Key");
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRateDetail",
                schema: "BCS",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(10,5)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    ExchangeRateKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatorKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    CreatorUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdaterKey = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdater = table.Column<string>(type: "nvarchar(301)", maxLength: 301, nullable: true),
                    LastUpdaterUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRateDetail", x => x.Key);
                    table.ForeignKey(
                        name: "FK_ExchangeRateDetail_ExchangeRate_ExchangeRateKey",
                        column: x => x.ExchangeRateKey,
                        principalSchema: "BCS",
                        principalTable: "ExchangeRate",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "ExchangeRateResource",
                columns: new[] { "Key", "ApiKey", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "ResourceName", "ResourceUri" },
                values: new object[] { new Guid("db1d8ab3-a521-4f6c-8c94-729ce1ea491d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, "Europesn Central Bank", "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?4610f020d7463a0cd43d6828905faf2f" });

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRate_ExchangeRateResourceKey",
                schema: "BCS",
                table: "ExchangeRate",
                column: "ExchangeRateResourceKey");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRateDetail_ExchangeRateKey",
                schema: "BCS",
                table: "ExchangeRateDetail",
                column: "ExchangeRateKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRateDetail",
                schema: "BCS");

            migrationBuilder.DropTable(
                name: "ExchangeRate",
                schema: "BCS");

            migrationBuilder.DropTable(
                name: "ExchangeRateResource",
                schema: "BCS");
        }
    }
}
