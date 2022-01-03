using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apitest4.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bus",
                columns: table => new
                {
                    Placa = table.Column<string>(maxLength: 10, nullable: false),
                    Nombres_Chofer = table.Column<string>(maxLength: 40, nullable: false),
                    Nombres_Asistente = table.Column<string>(maxLength: 40, nullable: false),
                    Correo_Chofer = table.Column<string>(maxLength: 60, nullable: false),
                    Correo_Asistente = table.Column<string>(maxLength: 60, nullable: false),
                    Cedula_Chofer = table.Column<string>(maxLength: 60, nullable: false),
                    Cedula_Asistente = table.Column<string>(maxLength: 60, nullable: false),
                    Marca = table.Column<string>(maxLength: 20, nullable: false),
                    Cooperativa = table.Column<string>(maxLength: 40, nullable: false),
                    Wifi = table.Column<bool>(nullable: false),
                    TV = table.Column<bool>(nullable: false),
                    Baño = table.Column<bool>(nullable: false),
                    Asientos_discapacitados = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bus", x => x.Placa);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Apellido = table.Column<string>(maxLength: 40, nullable: false),
                    Correo = table.Column<string>(maxLength: 60, nullable: false),
                    Contrasenia = table.Column<string>(maxLength: 60, nullable: false),
                    Administrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Parada",
                columns: table => new
                {
                    ParadaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 40, nullable: false),
                    Sector = table.Column<string>(maxLength: 40, nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: true),
                    IdBus = table.Column<string>(maxLength: 10, nullable: false),
                    BusPlaca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parada", x => x.ParadaId);
                    table.ForeignKey(
                        name: "FK_Parada_Bus_BusPlaca",
                        column: x => x.BusPlaca,
                        principalTable: "Bus",
                        principalColumn: "Placa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    ReporteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mala_Conduccion = table.Column<bool>(nullable: false),
                    Acoso = table.Column<bool>(nullable: false),
                    Nota = table.Column<string>(type: "text", nullable: false),
                    IdBus = table.Column<string>(maxLength: 10, nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    BusPlaca = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporte", x => x.ReporteId);
                    table.ForeignKey(
                        name: "FK_Reporte_Bus_BusPlaca",
                        column: x => x.BusPlaca,
                        principalTable: "Bus",
                        principalColumn: "Placa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reporte_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resena",
                columns: table => new
                {
                    ResenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calificacion = table.Column<int>(nullable: true),
                    Nota = table.Column<string>(type: "text", nullable: true),
                    IdBus = table.Column<string>(maxLength: 10, nullable: false),
                    IdUsuario = table.Column<int>(nullable: false),
                    BusPlaca = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resena", x => x.ResenaId);
                    table.ForeignKey(
                        name: "FK_Resena_Bus_BusPlaca",
                        column: x => x.BusPlaca,
                        principalTable: "Bus",
                        principalColumn: "Placa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resena_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parada_BusPlaca",
                table: "Parada",
                column: "BusPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Reporte_BusPlaca",
                table: "Reporte",
                column: "BusPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Reporte_UsuarioId",
                table: "Reporte",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Resena_BusPlaca",
                table: "Resena",
                column: "BusPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Resena_UsuarioId",
                table: "Resena",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parada");

            migrationBuilder.DropTable(
                name: "Reporte");

            migrationBuilder.DropTable(
                name: "Resena");

            migrationBuilder.DropTable(
                name: "Bus");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
