﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class ADDISBNTOBOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");
        }
    }
}
