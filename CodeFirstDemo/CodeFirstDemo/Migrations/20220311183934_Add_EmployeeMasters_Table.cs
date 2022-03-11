using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstDemo.Migrations
{
    public partial class Add_EmployeeMasters_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMasters");
        }
    }
}
