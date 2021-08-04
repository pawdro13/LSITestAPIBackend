using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LsiTestWebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfRaport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "DateOfRaport", "LocalName", "Name", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 3, 14, 20, 13, 501, DateTimeKind.Local).AddTicks(4799), "Lokal 1", "Raport 1", "User 1" },
                    { 2, new DateTime(2021, 8, 3, 14, 20, 13, 506, DateTimeKind.Local).AddTicks(4211), "Lokal 1", "Raport 1", "User 1" },
                    { 3, new DateTime(2021, 8, 3, 14, 20, 13, 506, DateTimeKind.Local).AddTicks(4325), "Lokal 1", "Raport 1", "User 1" },
                    { 4, new DateTime(2021, 8, 3, 14, 20, 13, 506, DateTimeKind.Local).AddTicks(4338), "Lokal 1", "Raport 1", "User 1" },
                    { 5, new DateTime(2021, 8, 3, 14, 20, 13, 506, DateTimeKind.Local).AddTicks(4346), "Lokal 1", "Raport 1", "User 1" },
                    { 6, new DateTime(2021, 8, 3, 14, 20, 13, 506, DateTimeKind.Local).AddTicks(4355), "Lokal 1", "Raport 1", "User 1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
