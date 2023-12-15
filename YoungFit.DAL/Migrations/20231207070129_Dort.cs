using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Dort : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YemekZamani",
                table: "Yemekler",
                type: "NVARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YemekZamani",
                table: "Yemekler",
                type: "NVARCHAR(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)",
                oldNullable: true);
        }
    }
}
