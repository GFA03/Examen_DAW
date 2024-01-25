using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_DAW.Server.Migrations
{
    /// <inheritdoc />
    public partial class relatii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfesorMaterie",
                columns: table => new
                {
                    ProfesorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesorMaterie", x => new { x.ProfesorId, x.MaterieId });
                    table.ForeignKey(
                        name: "FK_ProfesorMaterie_Materii_MaterieId",
                        column: x => x.MaterieId,
                        principalTable: "Materii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesorMaterie_Profesori_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Profesori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfesorMaterie_MaterieId",
                table: "ProfesorMaterie",
                column: "MaterieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfesorMaterie");
        }
    }
}
