using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetTechApi.Migrations
{
    /// <inheritdoc />
    public partial class BUNGAS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tutors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tutors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "veterinarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Crmv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pets", x => x.id);
                    table.ForeignKey(
                        name: "FK_pets_tutors_tutorId",
                        column: x => x.tutorId,
                        principalTable: "tutors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "consultas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    petId = table.Column<int>(type: "int", nullable: false),
                    veterinarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultas", x => x.id);
                    table.ForeignKey(
                        name: "FK_consultas_pets_petId",
                        column: x => x.petId,
                        principalTable: "pets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_consultas_veterinarios_veterinarioId",
                        column: x => x.veterinarioId,
                        principalTable: "veterinarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_consultas_petId",
                table: "consultas",
                column: "petId");

            migrationBuilder.CreateIndex(
                name: "IX_consultas_veterinarioId",
                table: "consultas",
                column: "veterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_pets_tutorId",
                table: "pets",
                column: "tutorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultas");

            migrationBuilder.DropTable(
                name: "pets");

            migrationBuilder.DropTable(
                name: "veterinarios");

            migrationBuilder.DropTable(
                name: "tutors");
        }
    }
}
