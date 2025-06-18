using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Adress", "AreaInSqrMeters", "ImageUrl", "MarketPrice", "YearOfConstruction" },
                values: new object[,]
                {
                    { 1, "123 Main Street, Sofia, Bulgaria", 120.5, null, 250000.00m, 2010 },
                    { 2, "45 Coastal Road, Varna, Bulgaria", 95.0, null, 320000.00m, 2018 },
                    { 3, "7 Mountain View, Bansko, Bulgaria", 85.0, null, 180000.00m, 2005 },
                    { 4, "22 Central Square, Plovdiv, Bulgaria", 150.0, null, 290000.00m, 2015 },
                    { 5, "15 Riverside, Ruse, Bulgaria", 110.0, null, 210000.00m, 2020 }
                });

            migrationBuilder.InsertData(
                table: "TransportAssets",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "OwnerId", "Price", "Type", "YearOfManufacture" },
                values: new object[,]
                {
                    { 1, "Reliable sedan with great fuel economy", null, "Toyota Camry", 2, 22000.00m, 0, 2018 },
                    { 2, "Classic American cruiser motorcycle", null, "Harley-Davidson Sportster", 3, 12500.00m, 2, 2020 },
                    { 3, "24-foot luxury bowrider", null, "Sea Ray Sundancer", 4, 45000.00m, 8, 2015 },
                    { 4, "Full-size pickup truck, 4WD", null, "Ford F-150", 5, 35000.00m, 1, 2019 },
                    { 5, "Electric vehicle with autopilot", null, "Tesla Model 3", 6, 48000.00m, 0, 2021 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "8a4ded1c-d813-4fcb-9e00-68efc7cf724d", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8840), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8840), "278e0166-1837-4f02-b02e-cb45aae652a4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "db0f1d2c-3016-498d-bd3f-f9a76350b119", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8903), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8903), "6414ca0a-e961-47c5-85a6-3348cef9e3d0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "8196f3be-b108-45d1-869b-2d9cbaf57158", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8918), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8919), "57344615-1722-4178-a3aa-bf816ed77902" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "eeaab2df-5f50-42b9-ae30-2fc03b592dc6", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8926), "58737cc9-fa0e-4cdd-b0a2-d597e6fdd536" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "004e1295-f3d7-4724-ae04-bbcb6c9b02ad", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8938), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8938), "10bfba81-5b28-4ceb-a100-b07904fcf3c0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "56f6ba17-7edf-44fe-908a-43ef728d955b", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8947), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8947), "e3fe81a8-ce39-4e18-b71a-7a7fe34857fd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "69294454-f4fd-4477-a7c2-4435a3e4e23c", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8960), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8960), "97c620d1-2d98-4992-9603-416906631fdb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "ec8243e8-e4f1-4389-bb63-aee7ca8e9e49", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8969), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8969), "57bc68d2-d19a-4944-8391-c4a4448e32db" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "faaa0bd6-abcc-49b0-bba4-c721efc6f23c", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8976), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8977), "d02082a2-24aa-4ce1-9ed9-c34600297e8b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "ff2bcd77-2796-4aa3-a363-73ef39f04693", new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8986), new DateTime(2025, 6, 18, 5, 4, 29, 93, DateTimeKind.Utc).AddTicks(8986), "47140852-aab1-4f80-ba30-e0f00a0616e6" });

            migrationBuilder.InsertData(
                table: "RealEstatesOwnerships",
                columns: new[] { "RealEstateId", "UserId", "DateAcquired", "Id", "OwnershipPercentage" },
                values: new object[,]
                {
                    { 1, 5, new DateOnly(2023, 6, 18), 1, 100.0 },
                    { 2, 6, new DateOnly(2023, 12, 18), 2, 100.0 },
                    { 3, 7, new DateOnly(2024, 6, 18), 3, 100.0 },
                    { 4, 8, new DateOnly(2024, 9, 18), 4, 100.0 },
                    { 5, 9, new DateOnly(2024, 12, 18), 5, 100.0 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "LastChanged", "PricePerMonth", "RealEstateId", "ServiceType", "SignatoryId", "Signed", "TransportAssetId" },
                values: new object[,]
                {
                    { 1, "Comprehensive auto insurance", new DateOnly(2025, 5, 18), 120.00m, null, 1, 2, new DateOnly(2024, 6, 18), 1 },
                    { 2, "Motorcycle full coverage", new DateOnly(2025, 6, 18), 85.00m, null, 1, 3, new DateOnly(2024, 12, 18), 2 },
                    { 3, "GPS tracking system subscription", new DateOnly(2025, 6, 18), 45.00m, null, 0, 4, new DateOnly(2025, 3, 18), 3 },
                    { 4, "Property damage insurance for Sofia apartment", new DateOnly(2025, 3, 18), 250.00m, 1, 1, 5, new DateOnly(2023, 6, 18), null },
                    { 5, "Security system for Varna beach house", new DateOnly(2025, 4, 18), 180.00m, 2, 0, 6, new DateOnly(2023, 12, 18), null },
                    { 6, "Ski chalet insurance in Bansko", new DateOnly(2025, 6, 18), 150.00m, 3, 1, 7, new DateOnly(2024, 6, 18), null },
                    { 7, "Plovdiv city center property security", new DateOnly(2025, 6, 18), 200.00m, 4, 0, 8, new DateOnly(2024, 9, 18), null },
                    { 8, "Ruse riverside apartment insurance", new DateOnly(2025, 6, 18), 175.00m, 5, 1, 9, new DateOnly(2024, 12, 18), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RealEstatesOwnerships",
                keyColumns: new[] { "RealEstateId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "RealEstatesOwnerships",
                keyColumns: new[] { "RealEstateId", "UserId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "RealEstatesOwnerships",
                keyColumns: new[] { "RealEstateId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "RealEstatesOwnerships",
                keyColumns: new[] { "RealEstateId", "UserId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "RealEstatesOwnerships",
                keyColumns: new[] { "RealEstateId", "UserId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TransportAssets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TransportAssets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TransportAssets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransportAssets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransportAssets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "09d02b36-3fd4-4271-9388-47c36bb3403f", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4174), "9f14a7d4-ff63-41e5-a0ac-d9fa72135556" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "6ae170c9-1c11-479e-a5c5-4aa032c2f195", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4187), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4187), "34ab1853-754e-41af-b92f-6a473fdf1681" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "43822928-aba3-4878-a60a-82ad67271499", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4193), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4194), "87758602-0636-4ed2-b968-147ca26a6d71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "9d048cc2-aa4e-482f-9c99-61495abb9c46", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4202), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4202), "51897d4a-35e1-4d93-8339-e374ed5cd6e7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "12b24db0-7f4d-41fe-9c1d-a86a280f0422", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4254), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4255), "98614188-2db6-4ee5-8feb-77471a865f33" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "4e94be6b-1f5e-416e-9d51-72343906eed4", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4267), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4267), "5699cb4a-c099-49c2-8f22-80ad9be4d972" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "0bdab2ef-3474-4b28-81ec-46259aa6debe", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4274), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4274), "dabddecb-f3db-4a05-83a9-80b3f21ad567" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "b7f02981-e06a-4eba-b7df-95d274144768", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4280), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4281), "f8330541-e645-412b-bf3f-178f11208713" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "b338159e-8873-45f8-a062-0a78b4238d83", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4289), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4289), "33083f68-9985-4661-a40c-fb3fb922e210" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "SecurityStamp" },
                values: new object[] { "861c2581-cfbe-4107-8a9b-4202312e174e", new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4296), new DateTime(2025, 6, 18, 4, 44, 16, 127, DateTimeKind.Utc).AddTicks(4296), "63d4a84e-5265-4a89-b6dd-e031ac618cb1" });
        }
    }
}
