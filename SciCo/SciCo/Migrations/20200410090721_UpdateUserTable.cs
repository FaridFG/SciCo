﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SciCo.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverPhoto",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverPhoto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "AspNetUsers");
        }
    }
}