using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCurrencyService.Data.Migrations
{
    public partial class Initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "BCS");

            migrationBuilder.CreateTable(
                name: "Audit",
                schema: "BCS",
                columns: table => new
                {
                    Key = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Audit", x => x.Key);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit",
                schema: "BCS");
        }
    }
}
