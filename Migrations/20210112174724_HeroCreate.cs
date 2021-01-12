using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_Chinzaruc_Alexandra_MK3.Migrations
{
    public partial class HeroCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exhibit",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exhibit_Name = table.Column<string>(nullable: true),
                    Comic_Universe = table.Column<string>(nullable: true),
                    Hero_Power = table.Column<string>(nullable: true),
                    Issue_of_Apparition = table.Column<decimal>(type: "decimal(6, 0)", nullable: false),
                    Issue_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibit", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exhibit");
        }
    }
}
