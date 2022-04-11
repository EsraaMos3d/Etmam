using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.EF.Migrations
{
    public partial class init88 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Name",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserNumber",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "User_Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
