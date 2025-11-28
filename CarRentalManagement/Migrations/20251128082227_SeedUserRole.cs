using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6ea8f95c-d028-4b55-9cb7-9033b4781742", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELyDNiKcRVxyILwu9O7Bje+o9sBdzQdC5Cb80wYl6oh0O1NCV9D5tobImlJelMYfTw==", null, false, "310c1d78-0ee0-4fa3-921a-337a647f50fc", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(2776), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3313), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3535), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3540), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3544), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 11, 28, 16, 22, 25, 416, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(8688), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(8711), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9220), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9224), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9413), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9417), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9420), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9424), new DateTime(2025, 11, 28, 16, 11, 6, 262, DateTimeKind.Local).AddTicks(9424) });
        }
    }
}
