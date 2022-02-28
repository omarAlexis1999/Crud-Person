using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlIngresoGasto.Migrations
{
    public partial class FirstMigrationPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    dni = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    address = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    country = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    city = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    birth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
