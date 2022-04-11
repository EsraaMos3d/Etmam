using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.EF.Migrations
{
    public partial class inituserapp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Ticket",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Ticket",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ApplicationUserId",
                table: "Ticket",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CreatedBy",
                table: "Ticket",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ModifiedBy",
                table: "Ticket",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_ApplicationUserId",
                table: "Ticket",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_CreatedBy",
                table: "Ticket",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_ModifiedBy",
                table: "Ticket",
                column: "ModifiedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_ApplicationUserId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_CreatedBy",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_ModifiedBy",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ApplicationUserId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_CreatedBy",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_ModifiedBy",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
