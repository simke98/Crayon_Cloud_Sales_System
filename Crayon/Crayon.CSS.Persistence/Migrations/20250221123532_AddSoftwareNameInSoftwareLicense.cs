using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crayon.CSS.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftwareNameInSoftwareLicense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SoftwareName",
                table: "SoftwareLicenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("94355fb5-45bc-41f1-ae1d-402d2dd4895b"),
                column: "SoftwareName",
                value: "Microsoft Teams");

            migrationBuilder.UpdateData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("bb23fb79-791d-423d-8da2-0543db31778d"),
                column: "SoftwareName",
                value: "Microsoft Teams");

            migrationBuilder.UpdateData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("e4b367c8-d8e0-437c-bc7b-089fb1b79fe6"),
                column: "SoftwareName",
                value: "Microsoft Teams");

            migrationBuilder.UpdateData(
                table: "SoftwareLicenses",
                keyColumn: "Id",
                keyValue: new Guid("ee517cfb-5470-4ce5-bdf1-eef88fca7ccb"),
                column: "SoftwareName",
                value: "Microsoft Teams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftwareName",
                table: "SoftwareLicenses");
        }
    }
}
