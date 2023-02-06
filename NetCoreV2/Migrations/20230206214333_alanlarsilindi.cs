using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreV2.Migrations
{
    /// <inheritdoc />
    public partial class alanlarsilindi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alan2",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "alan3",
                table: "Ogrenciler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alan2",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "alan3",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
