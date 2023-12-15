using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Iki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OlcuBirimi",
                table: "Yemekler",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OlcuBirimi",
                table: "Yemekler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");
        }
    }
}
