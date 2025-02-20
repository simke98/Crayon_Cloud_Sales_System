using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Crayon.CSS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), "Customer1", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), "Customer2", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), "Customer3", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "CustomerId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new Guid("11111111-1111-1111-1111-111111111111"), "Customer1 Primary", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new Guid("11111111-1111-1111-1111-111111111111"), "Customer1 Secondary", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new Guid("22222222-2222-2222-2222-222222222222"), "Customer2 Main", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new Guid("33333333-3333-3333-3333-333333333333"), "Customer3 Core", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SoftwareLicenses",
                columns: new[] { "Id", "AccountId", "CreatedAt", "ExpirationDate", "Quantity", "State", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("94355fb5-45bc-41f1-ae1d-402d2dd4895b"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 300, "Active", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb23fb79-791d-423d-8da2-0543db31778d"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 100, "Active", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4b367c8-d8e0-437c-bc7b-089fb1b79fe6"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 200, "Active", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee517cfb-5470-4ce5-bdf1-eef88fca7ccb"), new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 31, 12, 0, 0, 0, DateTimeKind.Unspecified), 50, "Active", new DateTime(2025, 2, 20, 10, 15, 32, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("94355fb5-45bc-41f1-ae1d-402d2dd4895b"));

            migrationBuilder.DeleteData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("bb23fb79-791d-423d-8da2-0543db31778d"));

            migrationBuilder.DeleteData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("e4b367c8-d8e0-437c-bc7b-089fb1b79fe6"));

            migrationBuilder.DeleteData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("ee517cfb-5470-4ce5-bdf1-eef88fca7ccb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
