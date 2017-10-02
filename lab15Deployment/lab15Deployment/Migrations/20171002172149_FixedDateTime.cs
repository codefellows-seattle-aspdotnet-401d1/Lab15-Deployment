using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace lab15Deployment.Migrations
{
    public partial class FixedDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Students");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }
    }
}
