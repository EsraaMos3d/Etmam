using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.EF.Migrations
{
    public partial class gggticket777 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Ticket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Ticket",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
