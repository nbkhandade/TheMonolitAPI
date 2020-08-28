using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMonolit.API.Migrations
{
    public partial class FundDataValues1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "FundDataValues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Year5",
                table: "FundDataValues",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "FundDataValues");

            migrationBuilder.DropColumn(
                name: "Year5",
                table: "FundDataValues");
        }
    }
}
