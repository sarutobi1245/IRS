﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace INK_API.Migrations
{
    public partial class version103henryUpdateAbnormalsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Batch",
                table: "Abnormals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Batch",
                table: "Abnormals");
        }
    }
}
