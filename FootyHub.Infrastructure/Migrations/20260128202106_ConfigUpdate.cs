using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConfigUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "NaturalPosition_DisplayName",
                table: "Players",
                newName: "PositionName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Players",
                newName: "LastName");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "PositionName",
                table: "Players",
                newName: "NaturalPosition_DisplayName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Players",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
