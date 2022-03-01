using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCurrencyService.Data.Migrations
{
    public partial class addcountrycurrensy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryCurrency",
                schema: "BCS",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    AcronymAbb = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    RowOrder = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_CountryCurrency", x => x.Key);
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "CountryCurrency",
                columns: new[] { "Key", "AcronymAbb", "CountryName", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "IsAvailable", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "RowOrder" },
                values: new object[,]
                {
                    { 1, "AUD", "Australia Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 2, "GBP", "Great Britain Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 3, "EUR", "Euro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 4, "JPY", "Japan Yen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 5, "CHF", "Switzerland Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 6, "USD", "USA Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 7, "AFN", "Afghanistan Afghani", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 8, "ALL", "Albania Lek", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 9, "DZD", "Algeria Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 10, "AOA", "Angola Kwanza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 11, "ARS", "Argentina Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 12, "AMD", "Armenia Dram", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 13, "AWG", "Aruba Florin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 14, "AUD", "Australia Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 15, "ATS (EURO)", "Austria Schilling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 16, "BEF (EURO)", "Belgium Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 17, "AZN", "Azerbaijan New Manat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 18, "BSD", "Bahamas Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 19, "BHD", "Bahrain Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 20, "BDT", "Bangladesh Taka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 21, "BBD", "Barbados Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 22, "BYR", "Belarus Ruble", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 23, "BZD", "Belize Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 24, "BMD", "Bermuda Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 25, "BTN", "Bhutan Ngultrum", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 26, "BOB", "Bolivia Boliviano", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 27, "BAM", "Bosnia Mark", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 28, "BWP", "Botswana Pula", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 29, "BRL", "Brazil Real", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 30, "GBP", "Great Britain Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 31, "BND", "Brunei Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 32, "BGN", "Bulgaria Lev", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 33, "BIF", "Burundi Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 34, "XOF", "CFA Franc BCEAO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 35, "XAF", "CFA Franc BEAC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 36, "XPF", "CFP Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 37, "KHR", "Cambodia Riel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 38, "CAD", "Canada Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 39, "CVE", "Cape Verde Escudo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 40, "KYD", "Cayman Islands Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 41, "CLP", "Chili Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 42, "CNY", "China Yuan/Renminbi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "CountryCurrency",
                columns: new[] { "Key", "AcronymAbb", "CountryName", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "IsAvailable", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "RowOrder" },
                values: new object[,]
                {
                    { 43, "COP", "Colombia Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 44, "KMF", "Comoros Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 45, "CDF", "Congo Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 46, "CRC", "Costa Rica Colon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 47, "HRK", "Croatia Kuna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 48, "CUC", "Cuba Convertible Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 49, "CUP", "Cuba Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 50, "CYP (EURO)", "Cyprus Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 51, "CZK", "Czech Koruna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 52, "DKK", "Denmark Krone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 53, "DJF", "Djibouti Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 54, "DOP", "Dominican Republich Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 55, "XCD", "East Caribbean Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 56, "EGP", "Egypt Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 57, "SVC", "El Salvador Colon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 58, "EEK (EURO)", "Estonia Kroon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 59, "ETB", "Ethiopia Birr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 60, "EUR", "Euro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 61, "FKP", "Falkland Islands Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 62, "FIM (EURO)", "Finland Markka", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 63, "FJD", "Fiji Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 64, "GMD", "Gambia Dalasi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 65, "GEL", "Georgia Lari", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 66, "DMK (EURO)", "Germany Mark", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 67, "GHS", "Ghana New Cedi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 68, "GIP", "Gibraltar Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 69, "GRD (EURO)", "Greece Drachma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 70, "GTQ", "Guatemala Quetzal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 71, "GNF", "Guinea Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 72, "GYD", "Guyana Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 73, "HTG", "Haiti Gourde", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 74, "HNL", "Honduras Lempira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 75, "HKD", "Hong Kong Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 76, "HUF", "Hungary Forint", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 77, "ISK", "Iceland Krona", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 78, "INR", "India Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 79, "IDR", "Indonesia Rupiah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 80, "IRR", "Iran Rial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 81, "IQD", "Iraq Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 82, "IED (EURO)", "Ireland Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 83, "ILS", "Israel New Shekel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 84, "ITL (EURO)", "Italy Lira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "CountryCurrency",
                columns: new[] { "Key", "AcronymAbb", "CountryName", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "IsAvailable", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "RowOrder" },
                values: new object[,]
                {
                    { 85, "JMD", "Jamaica Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 86, "JPY", "Japan Yen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 87, "JOD", "Jordan Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 88, "KZT", "Kazakhstan Tenge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 89, "KES", "Kenya Shilling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 90, "KWD", "Kuwait Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 91, "KGS", "Kyrgyzstan Som", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 92, "LAK", "Laos Kip", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 93, "LVL (EURO)", "Latvia Lats", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 94, "LBP", "Lebanon Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 95, "LSL", "Lesotho Loti", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 96, "LRD", "Liberia Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 97, "LYD", "Libya Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 98, "LTL (EURO)", "Lithuania Litas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 99, "LUF (EURO)", "Luxembourg Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 100, "MOP", "Macau Pataca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 101, "MKD", "Macedonia Denar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 102, "MGA", "Malagasy Ariary", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 103, "MWK", "Malawi Kwacha", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 104, "MYR", "Malaysia Ringgit", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 105, "MVR", "Maldives Rufiyaa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 106, "MTL (EURO)", "Malta Lira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 107, "MRO", "Mauritania Ouguiya", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 108, "MUR", "Mauritius Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 109, "MXN", "Mexico Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 110, "MDL", "Moldova Leu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 111, "MNT", "Mongolia Tugrik", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 112, "MAD", "Morocco Dirham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 113, "MZN", "Mozambique New Metical", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 114, "MMK", "Myanmar Kyat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 115, "ANG", "NL Antilles Guilder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 116, "NAD", "Namibia Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 117, "NPR", "Nepal Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 118, "NLG (EURO)", "Netherlands Guilder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 119, "NZD", "New Zealand Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 120, "NIO", "Nicaragua Cordoba Oro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 121, "NGN", "Nigeria Naira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 122, "KPW", "North Korea Won", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 123, "NOK", "Norway Kroner", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 124, "OMR", "Oman Rial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 125, "PKR", "Pakistan Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 126, "PAB", "Panama Balboa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "CountryCurrency",
                columns: new[] { "Key", "AcronymAbb", "CountryName", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "IsAvailable", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "RowOrder" },
                values: new object[,]
                {
                    { 127, "PGK", "Papua New Guinea Kina", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 128, "PYG", "Paraguay Guarani", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 129, "PEN", "Peru Nuevo Sol", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 130, "PHP", "Philippines Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 131, "PLN", "Poland Zloty", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 132, "PTE (EURO)", "Portugal Escudo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 133, "QAR", "Qatar Rial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 134, "RON", "Romania New Lei", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 135, "RUB", "Russia Rouble", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 136, "RWF", "Rwanda Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 137, "WST", "Samoa Tala", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 138, "STD", "Sao Tome/Principe Dobra", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 139, "SAR", "Saudi Arabia Riyal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 140, "RSD", "Serbia Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 141, "SCR", "Seychelles Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 142, "SLL", "Sierra Leone Leone", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 143, "SGD", "Singapore Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 144, "SKK (EURO)", "Slovakia Koruna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 145, "SIT (EURO)", "Slovenia Tolar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 146, "SBD", "Solomon Islands Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 147, "SOS", "Somali Shilling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 148, "ZAR", "South Africa Rand", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 149, "KRW", "South Korea Won", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 150, "ESP (EURO)", "Spain Peseta", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 151, "LKR", "Sri Lanka Rupee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 152, "SHP", "St Helena Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 153, "SDG", "Sudan Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 154, "SRD", "Suriname Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 155, "SZL", "Swaziland Lilangeni", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 156, "SEK", "Sweden Krona", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 157, "CHF", "Switzerland Franc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 158, "SYP", "Syria Pound", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 159, "TWD", "Taiwan Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 160, "TZS", "Tanzania Shilling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 161, "THB", "Thailand Baht", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 162, "TOP", "Tonga Pa'anga", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 163, "TTD", "Trinidad/Tobago Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 164, "TND", "Tunisia Dinar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 165, "TRY", "Turkish New Lira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 166, "TMM", "Turkmenistan Manat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 167, "USD", "USA Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 168, "UGX", "Uganda Shilling", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                schema: "BCS",
                table: "CountryCurrency",
                columns: new[] { "Key", "AcronymAbb", "CountryName", "CreatedDate", "Creator", "CreatorKey", "CreatorUserName", "IsAvailable", "LastUpdatedDate", "LastUpdater", "LastUpdaterKey", "LastUpdaterUserName", "RowOrder" },
                values: new object[,]
                {
                    { 169, "UAH", "Ukraine Hryvnia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 170, "UYU", "Uruguay Peso", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 171, "AED", "United Arab Emirates Dirham", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 172, "VUV", "Vanuatu Vatu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 173, "VEB", "Venezuela Bolivar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 174, "VND", "Vietnam Dong", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 175, "YER", "Yemen Rial", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 176, "ZMK", "Zambia Kwacha", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 },
                    { 177, "ZWD", "Zimbabwe Dollar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, null, null, null, null, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryCurrency",
                schema: "BCS");
        }
    }
}
