using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMonolit.API.Migrations
{
    public partial class FundDataValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundDataValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FundName = table.Column<string>(nullable: true),
                    Ticker = table.Column<string>(nullable: true),
                    Month1 = table.Column<float>(nullable: false),
                    Month3 = table.Column<float>(nullable: false),
                    Year = table.Column<float>(nullable: false),
                    Year3 = table.Column<float>(nullable: false),
                    InceptionToDate = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundDataValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FundDataValues");

            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
