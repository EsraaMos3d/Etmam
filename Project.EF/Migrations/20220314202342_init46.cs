using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.EF.Migrations
{
    public partial class init46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Branch_Id = table.Column<int>(nullable: true),
                    FK_College_Id = table.Column<int>(nullable: true),
                    FK_Department_Id = table.Column<int>(nullable: true),
                    FK_User_ID = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    DeletedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_Id);
                    table.ForeignKey(
                        name: "FK_Student_AspNetUsers_FK_User_ID",
                        column: x => x.FK_User_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_FK_User_ID",
                table: "Student",
                column: "FK_User_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
