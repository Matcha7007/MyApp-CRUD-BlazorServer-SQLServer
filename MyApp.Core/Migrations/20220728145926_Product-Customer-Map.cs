using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Core.Migrations
{
    public partial class ProductCustomerMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "CustomerProductTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProductTypes_EmployeeId",
                table: "CustomerProductTypes",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerProductTypes_Employees_EmployeeId",
                table: "CustomerProductTypes",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerProductTypes_Employees_EmployeeId",
                table: "CustomerProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_CustomerProductTypes_EmployeeId",
                table: "CustomerProductTypes");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "CustomerProductTypes");
        }
    }
}
