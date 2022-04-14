using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e.moiroServer.Migrations
{
    public partial class AddSecondTimeAndShifts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayOfTheWeek",
                table: "ClassTimes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondTimeEnd",
                table: "ClassTimes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SecondTimeStart",
                table: "ClassTimes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Shift",
                table: "ClassTimes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfTheWeek",
                table: "ClassTimes");

            migrationBuilder.DropColumn(
                name: "SecondTimeEnd",
                table: "ClassTimes");

            migrationBuilder.DropColumn(
                name: "SecondTimeStart",
                table: "ClassTimes");

            migrationBuilder.DropColumn(
                name: "Shift",
                table: "ClassTimes");
        }
    }
}
