using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Transport.Migrations
{
    /// <inheritdoc />
    public partial class manifest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Manifests");

            migrationBuilder.RenameColumn(
                name: "ManifestId",
                table: "Manifests",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ManifestItemId",
                table: "ManifestItems",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LicenseNo",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PAN",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Consignee",
                table: "ManifestItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "ManifestItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentMode",
                table: "ManifestItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ManifestItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "LicenseNo",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "PAN",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Manifests");

            migrationBuilder.DropColumn(
                name: "Consignee",
                table: "ManifestItems");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "ManifestItems");

            migrationBuilder.DropColumn(
                name: "PaymentMode",
                table: "ManifestItems");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ManifestItems");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manifests",
                newName: "ManifestId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ManifestItems",
                newName: "ManifestItemId");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Manifests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Manifests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
