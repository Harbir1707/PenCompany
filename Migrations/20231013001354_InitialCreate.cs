using Microsoft.EntityFrameworkCore.Migrations;

namespace PenCompany.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Pen");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Pen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Pen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InkType",
                table: "Pen",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRefillable",
                table: "Pen",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Pen",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Pen");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Pen");

            migrationBuilder.DropColumn(
                name: "InkType",
                table: "Pen");

            migrationBuilder.DropColumn(
                name: "IsRefillable",
                table: "Pen");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Pen");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Pen",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
