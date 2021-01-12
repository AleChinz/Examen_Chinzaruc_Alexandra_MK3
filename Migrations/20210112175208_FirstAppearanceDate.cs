using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_Chinzaruc_Alexandra_MK3.Migrations
{
    public partial class FirstAppearanceDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FirstAppearanceDate",
                table: "Exhibit",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstAppearanceDate",
                table: "Exhibit");
        }
    }
}
