using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class Blockchain2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "BlockchainContracts");

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "BlockchainContracts",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfDath",
                table: "BlockchainContracts",
                maxLength: 64,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GPS",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "BlockchainContracts",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "DateOfDath",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "GPS",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "BlockchainContracts");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "BlockchainContracts");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "BlockchainContracts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
