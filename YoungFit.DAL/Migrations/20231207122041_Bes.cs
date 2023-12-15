using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Bes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YemekAdı",
                table: "KullaniciYemekler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YemekAdı",
                table: "KullaniciYemekler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
