using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelmerDemo.WebShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerDetailsAndAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerDetailId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UniqueId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CustomersDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_CustomersDetails_CustomerDetailId",
                        column: x => x.CustomerDetailId,
                        principalTable: "CustomersDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerDetailId",
                table: "Customers",
                column: "CustomerDetailId",
                unique: true,
                filter: "[CustomerDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerDetailId",
                table: "Addresses",
                column: "CustomerDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomersDetails_CustomerDetailId",
                table: "Customers",
                column: "CustomerDetailId",
                principalTable: "CustomersDetails",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomersDetails_CustomerDetailId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CustomersDetails");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerDetailId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerDetailId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UniqueId",
                table: "Customers");
        }
    }
}
