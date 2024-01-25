using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_DAW.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Profesori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Profesori");
        }
    }
}
