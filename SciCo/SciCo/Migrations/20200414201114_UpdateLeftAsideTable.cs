using Microsoft.EntityFrameworkCore.Migrations;

namespace SciCo.Migrations
{
    public partial class UpdateLeftAsideTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "LeftAsides",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "LeftAsides");
        }
    }
}
