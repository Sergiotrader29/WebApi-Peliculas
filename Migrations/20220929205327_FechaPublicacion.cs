﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class FechaPublicacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicacion",
                table: "Libros",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaPublicacion",
                table: "Libros");
        }
    }
}
