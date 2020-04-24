using Microsoft.EntityFrameworkCore.Migrations;

namespace SciCo.Migrations
{
    public partial class UpdateCommentsAndPostsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Comments_CommentsId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CommentsId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CommentsId",
                table: "Posts");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CommentsId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CommentsId",
                table: "Posts",
                column: "CommentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Comments_CommentsId",
                table: "Posts",
                column: "CommentsId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
