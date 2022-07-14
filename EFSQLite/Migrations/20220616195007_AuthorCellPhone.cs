﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSQLite.Migrations
{
    public partial class AuthorCellPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CellPhone",
                table: "Authors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CellPhone",
                table: "Authors");
        }
    }
}
