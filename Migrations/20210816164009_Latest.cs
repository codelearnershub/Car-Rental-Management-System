using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalsSystem.Migrations
{
    public partial class Latest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CardPin",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNo",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CardPin",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
