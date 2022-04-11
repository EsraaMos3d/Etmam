using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.EF.Migrations
{
    public partial class inity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketStatus_TicketStatus_ID",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketType_TicketType_ID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_TicketStatus_ID",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_TicketType_ID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketStatus",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketStatus_ID",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketType",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketType_ID",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "FK_TicketStatus_Id",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FK_TicketType_Id",
                table: "Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FK_TicketStatus_Id",
                table: "Ticket",
                column: "FK_TicketStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FK_TicketType_Id",
                table: "Ticket",
                column: "FK_TicketType_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketStatus_FK_TicketStatus_Id",
                table: "Ticket",
                column: "FK_TicketStatus_Id",
                principalTable: "TicketStatus",
                principalColumn: "TicketStatus_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketType_FK_TicketType_Id",
                table: "Ticket",
                column: "FK_TicketType_Id",
                principalTable: "TicketType",
                principalColumn: "TicketType_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketStatus_FK_TicketStatus_Id",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketType_FK_TicketType_Id",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FK_TicketStatus_Id",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FK_TicketType_Id",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FK_TicketStatus_Id",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FK_TicketType_Id",
                table: "Ticket");

            migrationBuilder.AddColumn<string>(
                name: "TicketStatus",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketStatus_ID",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TicketType",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketType_ID",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStatus_ID",
                table: "Ticket",
                column: "TicketStatus_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketType_ID",
                table: "Ticket",
                column: "TicketType_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketStatus_TicketStatus_ID",
                table: "Ticket",
                column: "TicketStatus_ID",
                principalTable: "TicketStatus",
                principalColumn: "TicketStatus_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketType_TicketType_ID",
                table: "Ticket",
                column: "TicketType_ID",
                principalTable: "TicketType",
                principalColumn: "TicketType_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
