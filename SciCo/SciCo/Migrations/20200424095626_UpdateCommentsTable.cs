using Microsoft.EntityFrameworkCore.Migrations;

namespace SciCo.Migrations
{
    public partial class UpdateCommentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentReceiverId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "CommentReceiverId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentReceiverId",
                table: "Comments",
                column: "CommentReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments",
                column: "CommentReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
