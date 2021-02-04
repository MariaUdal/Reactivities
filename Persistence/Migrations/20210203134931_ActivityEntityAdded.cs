using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ActivityEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Activities",
                table => new
                {
                    Id = table.Column<Guid>("TEXT", nullable: false),
                    Title = table.Column<string>("TEXT", nullable: true),
                    Description = table.Column<string>("TEXT", nullable: true),
                    Category = table.Column<string>("TEXT", nullable: true),
                    Date = table.Column<DateTime>("TEXT", nullable: false),
                    City = table.Column<string>("TEXT", nullable: true),
                    Venue = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Activities", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Activities");
        }
    }
}