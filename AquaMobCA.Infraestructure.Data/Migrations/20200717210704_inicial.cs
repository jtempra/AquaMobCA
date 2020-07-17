using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Persistence.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    NIF = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Movil = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PathFoto = table.Column<string>(nullable: true),
                    Rol = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncidenciaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    UserEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidenciaEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidenciaEntity_UserEntity_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LecturaEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    UserEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturaEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LecturaEntity_UserEntity_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OTEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    UserEntityId = table.Column<int>(nullable: true),
                    UserEntityId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OTEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OTEntity_UserEntity_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OTEntity_UserEntity_UserEntityId1",
                        column: x => x.UserEntityId1,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnotacionesOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Anotacion = table.Column<string>(maxLength: 250, nullable: false),
                    Fecha = table.Column<DateTime>(type: "DateTime", nullable: false),
                    OperarioId = table.Column<int>(nullable: true),
                    OrdenTrabajoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotacionesOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnotacionesOT_UserEntity_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnotacionesOT_OTEntity_OrdenTrabajoId",
                        column: x => x.OrdenTrabajoId,
                        principalTable: "OTEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnotacionesOT_OperarioId",
                table: "AnotacionesOT",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AnotacionesOT_OrdenTrabajoId",
                table: "AnotacionesOT",
                column: "OrdenTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidenciaEntity_UserEntityId",
                table: "IncidenciaEntity",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturaEntity_UserEntityId",
                table: "LecturaEntity",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OTEntity_UserEntityId",
                table: "OTEntity",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OTEntity_UserEntityId1",
                table: "OTEntity",
                column: "UserEntityId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotacionesOT");

            migrationBuilder.DropTable(
                name: "IncidenciaEntity");

            migrationBuilder.DropTable(
                name: "LecturaEntity");

            migrationBuilder.DropTable(
                name: "OTEntity");

            migrationBuilder.DropTable(
                name: "UserEntity");
        }
    }
}
