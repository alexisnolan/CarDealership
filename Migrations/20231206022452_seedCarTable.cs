using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealership.Migrations
{
    /// <inheritdoc />
    public partial class seedCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "CarID", "DateReceived", "DateSold", "Make", "Mileage", "Model", "Status", "VIN", "Year" },
                values: new object[] { 1, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda", 50000, "CRV", "Sold", "1HGBH73JXMN10986", "2020" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "CarID",
                keyValue: 1);
        }
    }
}
