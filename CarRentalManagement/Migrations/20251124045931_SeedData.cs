using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(6834), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(6856), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(6861), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(6862), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7777), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7780), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7781), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7955), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7956), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7960), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7963), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7965), new DateTime(2025, 11, 24, 12, 59, 29, 486, DateTimeKind.Local).AddTicks(7966), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
