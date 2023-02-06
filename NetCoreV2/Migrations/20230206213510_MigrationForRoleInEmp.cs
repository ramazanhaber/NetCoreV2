using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreV2.Migrations
{
    /// <inheritdoc />
    public partial class MigrationForRoleInEmp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alan3",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alan3",
                table: "Ogrenciler");
        }
    }
}
