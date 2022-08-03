using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class Migra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalRole",
                table: "UserManagements");

            migrationBuilder.AddColumn<DateTime>(
                name: "PersonalDateTime",
                table: "UserManagements",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalDateTime",
                table: "UserManagements");

            migrationBuilder.AddColumn<string>(
                name: "PersonalRole",
                table: "UserManagements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
