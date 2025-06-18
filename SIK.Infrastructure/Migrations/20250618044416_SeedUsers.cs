using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsDeleated", "LastName", "LastUpdatedAt", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "09d02b36-3fd4-4271-9388-47c36bb3403f", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4174), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, "Admin", false, "User", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4174), false, null, "System", null, null, null, null, true, null, "9f14a7d4-ff63-41e5-a0ac-d9fa72135556", false, "admin@example.com" },
                    { 2, 0, "6ae170c9-1c11-479e-a5c5-4aa032c2f195", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4187), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", false, "John", false, "Doe", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4187), false, null, "Michael", null, null, null, null, false, null, "34ab1853-754e-41af-b92f-6a473fdf1681", false, "john.doe@example.com" },
                    { 3, 0, "43822928-aba3-4878-a60a-82ad67271499", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4193), new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", false, "Jane", false, "Smith", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4194), false, null, "Elizabeth", null, null, null, null, false, null, "87758602-0636-4ed2-b968-147ca26a6d71", false, "jane.smith@example.com" },
                    { 4, 0, "9d048cc2-aa4e-482f-9c99-61495abb9c46", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4202), new DateTime(1978, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "robert.johnson@example.com", false, "Robert", false, "Johnson", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4202), false, null, "Lee", null, null, null, null, false, null, "51897d4a-35e1-4d93-8339-e374ed5cd6e7", false, "robert.johnson@example.com" },
                    { 5, 0, "12b24db0-7f4d-41fe-9c1d-a86a280f0422", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4254), new DateTime(1992, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.wilson@example.com", false, "Emily", false, "Wilson", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4255), false, null, "Grace", null, null, null, null, false, null, "98614188-2db6-4ee5-8feb-77471a865f33", false, "emily.wilson@example.com" },
                    { 6, 0, "4e94be6b-1f5e-416e-9d51-72343906eed4", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4267), new DateTime(1987, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", false, "Michael", false, "Brown", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4267), false, null, "James", null, null, null, null, false, null, "5699cb4a-c099-49c2-8f22-80ad9be4d972", false, "michael.brown@example.com" },
                    { 7, 0, "0bdab2ef-3474-4b28-81ec-46259aa6debe", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4274), new DateTime(1995, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.davis@example.com", false, "Sarah", false, "Davis", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4274), false, null, "Anne", null, null, null, null, false, null, "dabddecb-f3db-4a05-83a9-80b3f21ad567", false, "sarah.davis@example.com" },
                    { 8, 0, "b7f02981-e06a-4eba-b7df-95d274144768", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4280), new DateTime(1983, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.miller@example.com", false, "David", false, "Miller", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4281), false, null, "Paul", null, null, null, null, false, null, "f8330541-e645-412b-bf3f-178f11208713", false, "david.miller@example.com" },
                    { 9, 0, "b338159e-8873-45f8-a062-0a78b4238d83", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4289), new DateTime(1991, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "lisa.moore@example.com", false, "Lisa", false, "Moore", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4289), false, null, "Marie", null, null, null, null, false, null, "33083f68-9985-4661-a40c-fb3fb922e210", false, "lisa.moore@example.com" },
                    { 10, 0, "861c2581-cfbe-4107-8a9b-4202312e174e", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4296), new DateTime(1975, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", false, "James", false, "Taylor", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4296), false, null, "William", null, null, null, null, false, null, "63d4a84e-5265-4a89-b6dd-e031ac618cb1", false, "james.taylor@example.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
