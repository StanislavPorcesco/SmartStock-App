using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartStock.Migrations
{
    /// <inheritdoc />
    public partial class AddProductIdToEconometricModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Clear orphaned rows before adding NOT NULL FK column — existing rows have no valid ProductId
            migrationBuilder.Sql("DELETE FROM EconometricModels;");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "EconometricModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 5, 24, 16, 1, 50, 171, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.CreateIndex(
                name: "IX_EconometricModels_ProductId",
                table: "EconometricModels",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_EconometricModels_Products_ProductId",
                table: "EconometricModels",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EconometricModels_Products_ProductId",
                table: "EconometricModels");

            migrationBuilder.DropIndex(
                name: "IX_EconometricModels_ProductId",
                table: "EconometricModels");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "EconometricModels");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 4, 10, 0, 15, 51, 397, DateTimeKind.Local).AddTicks(6709));
        }
    }
}
