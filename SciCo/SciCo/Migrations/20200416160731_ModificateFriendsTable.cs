using Microsoft.EntityFrameworkCore.Migrations;

namespace SciCo.Migrations
{
    public partial class ModificateFriendsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User2Id",
                table: "Friends",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "User1Id",
                table: "Friends",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Friends_User1Id",
                table: "Friends",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_User2Id",
                table: "Friends",
                column: "User2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User1Id",
                table: "Friends",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User2Id",
                table: "Friends",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User2Id",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_User1Id",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_User2Id",
                table: "Friends");

            migrationBuilder.AlterColumn<string>(
                name: "User2Id",
                table: "Friends",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "User1Id",
                table: "Friends",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
