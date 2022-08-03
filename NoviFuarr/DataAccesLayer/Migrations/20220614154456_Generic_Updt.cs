using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    public partial class Generic_Updt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalRole",
                table: "UserManagements",
                newName: "PersonalRoles");

            migrationBuilder.AddColumn<string>(
                name: "PriceTyp",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceTyp",
                table: "Visitors");

            migrationBuilder.RenameColumn(
                name: "PersonalRoles",
                table: "UserManagements",
                newName: "PersonalRole");
        }
    }
}
