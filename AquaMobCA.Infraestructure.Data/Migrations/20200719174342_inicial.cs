using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Persistence.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConceptosOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 25, nullable: false),
                    Concepto = table.Column<string>(maxLength: 100, nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptosOT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poblaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Poblacion = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poblaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RutasLectura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    NumeroLecturas = table.Column<int>(nullable: false),
                    NumeroLeidas = table.Column<int>(nullable: false),
                    Situacion = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "DateTime", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutasLectura", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIncidencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Tipo = table.Column<string>(maxLength: 100, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIncidencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIncidenciaLecturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Incidencia = table.Column<string>(maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIncidenciaLecturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposOrigenesIncidencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    OrigenIncidencia = table.Column<string>(nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOrigenesIncidencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Tipo = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposOT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    NIF = table.Column<string>(maxLength: 15, nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Calle = table.Column<string>(maxLength: 50, nullable: false),
                    PoblacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calles_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstalacionesOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Instalacion = table.Column<string>(maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: false),
                    PoblacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstalacionesOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstalacionesOT_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ZonasOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 10, nullable: false),
                    Zona = table.Column<string>(maxLength: 50, nullable: false),
                    PoblacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZonasOT_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricosLecturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    NumeroContrato = table.Column<int>(nullable: false),
                    Periodo = table.Column<int>(nullable: false),
                    Lectura = table.Column<double>(nullable: false),
                    FechaLectura = table.Column<DateTime>(nullable: false),
                    ConsumoLectura = table.Column<double>(nullable: false),
                    ConsumoImputado = table.Column<double>(nullable: false),
                    ConsumoEstimado = table.Column<double>(nullable: false),
                    ConsumoFacturado = table.Column<double>(nullable: false),
                    IncidenciaLecturaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricosLecturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricosLecturas_TiposIncidenciaLecturas_IncidenciaLecturaId",
                        column: x => x.IncidenciaLecturaId,
                        principalTable: "TiposIncidenciaLecturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Prioridad = table.Column<int>(nullable: false),
                    Situacion = table.Column<int>(nullable: false),
                    FechaSituacion = table.Column<DateTime>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 250, nullable: false),
                    Localizacion = table.Column<string>(maxLength: 250, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 500, nullable: false),
                    Solucion = table.Column<string>(maxLength: 500, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 500, nullable: false),
                    Latitud = table.Column<double>(nullable: false),
                    Longitud = table.Column<double>(nullable: false),
                    CreadaApp = table.Column<bool>(nullable: false),
                    NumeroContrato = table.Column<int>(nullable: false),
                    NombreAbonado = table.Column<string>(maxLength: 100, nullable: false),
                    MovilAbonado = table.Column<string>(maxLength: 15, nullable: false),
                    EMailAbonado = table.Column<string>(maxLength: 100, nullable: false),
                    OrigenId = table.Column<int>(nullable: true),
                    OperarioId = table.Column<int>(nullable: true),
                    TipoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidencias_Usuarios_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidencias_TiposOrigenesIncidencias_OrigenId",
                        column: x => x.OrigenId,
                        principalTable: "TiposOrigenesIncidencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidencias_TiposIncidencia_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposIncidencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lecturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    NumeroContrato = table.Column<int>(nullable: false),
                    NombreAbonado = table.Column<string>(maxLength: 100, nullable: false),
                    MovilAbonado = table.Column<string>(maxLength: 15, nullable: true),
                    EmailAbonado = table.Column<string>(maxLength: 100, nullable: true),
                    DireccionSuministro = table.Column<string>(maxLength: 100, nullable: false),
                    PoblacionSuministro = table.Column<string>(maxLength: 25, nullable: false),
                    OrdenRutaLectura = table.Column<string>(maxLength: 10, nullable: true),
                    UbicacionContador = table.Column<string>(maxLength: 100, nullable: true),
                    NumeroContador = table.Column<string>(maxLength: 25, nullable: false),
                    NumeroContadorNuevo = table.Column<string>(maxLength: 25, nullable: true),
                    RutaLecturaNueva = table.Column<string>(nullable: true),
                    OrdenRutaLecturaNueva = table.Column<string>(nullable: true),
                    LecturaAnterior = table.Column<double>(nullable: false),
                    LecturaActual = table.Column<double>(nullable: false),
                    LecturaNuevo = table.Column<double>(nullable: false),
                    FechaLecturaAnterior = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaLecturaActual = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaLecturaNuevo = table.Column<DateTime>(type: "DateTime", nullable: true),
                    SituacionLectura = table.Column<int>(nullable: false),
                    IncidenciaLecturaId = table.Column<int>(nullable: true),
                    IncidenciaContador = table.Column<int>(nullable: false),
                    ConsumoAnterior = table.Column<double>(nullable: false),
                    PromedioConsumo = table.Column<double>(nullable: false),
                    ObservacionesLectura = table.Column<string>(maxLength: 100, nullable: true),
                    ObservacionesSuministro = table.Column<string>(maxLength: 100, nullable: true),
                    Latitud = table.Column<double>(nullable: false),
                    Longitud = table.Column<double>(nullable: false),
                    Periodo = table.Column<int>(nullable: false),
                    Codigo1 = table.Column<string>(maxLength: 100, nullable: true),
                    Codigo2 = table.Column<string>(maxLength: 100, nullable: true),
                    Codigo3 = table.Column<string>(maxLength: 100, nullable: true),
                    RutaId = table.Column<int>(nullable: true),
                    OperarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lecturas_TiposIncidenciaLecturas_IncidenciaLecturaId",
                        column: x => x.IncidenciaLecturaId,
                        principalTable: "TiposIncidenciaLecturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lecturas_Usuarios_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lecturas_RutasLectura_RutaId",
                        column: x => x.RutaId,
                        principalTable: "RutasLectura",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubinstalacionesOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Subinstalacion = table.Column<string>(maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: false),
                    InstalacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubinstalacionesOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubinstalacionesOT_InstalacionesOT_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "InstalacionesOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquiposOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Equipo = table.Column<string>(maxLength: 50, nullable: false),
                    Observaciones = table.Column<string>(maxLength: 250, nullable: true),
                    SubinstalacionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiposOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquiposOT_SubinstalacionesOT_SubinstalacionId",
                        column: x => x.SubinstalacionId,
                        principalTable: "SubinstalacionesOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    TipoId = table.Column<int>(nullable: true),
                    Fecha = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CreadorId = table.Column<int>(nullable: true),
                    Situacion = table.Column<int>(nullable: false),
                    FechaSituacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Descripcion = table.Column<string>(maxLength: 1000, nullable: false),
                    Trabajos = table.Column<string>(maxLength: 1000, nullable: true),
                    PoblacionId = table.Column<int>(nullable: true),
                    CalleId = table.Column<int>(nullable: true),
                    ZonaId = table.Column<int>(nullable: true),
                    Direccion = table.Column<string>(maxLength: 250, nullable: false),
                    DireccionAdicional = table.Column<string>(maxLength: 250, nullable: true),
                    NumeroContrato = table.Column<int>(maxLength: 20, nullable: false),
                    NombreAbonado = table.Column<string>(maxLength: 50, nullable: true),
                    MovilCliente = table.Column<string>(maxLength: 20, nullable: true),
                    EMailCliente = table.Column<string>(maxLength: 100, nullable: true),
                    Prioridad = table.Column<int>(nullable: false),
                    Latitud = table.Column<double>(nullable: true),
                    Longitud = table.Column<double>(nullable: true),
                    InstalacionId = table.Column<int>(nullable: true),
                    SubInstalacionId = table.Column<int>(nullable: true),
                    EquipoId = table.Column<int>(nullable: true),
                    CreadaApp = table.Column<bool>(nullable: false),
                    Recurrente = table.Column<bool>(nullable: false),
                    Generica = table.Column<bool>(nullable: false),
                    PendienteObras = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesTrabajo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_Calles_CalleId",
                        column: x => x.CalleId,
                        principalTable: "Calles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_Usuarios_CreadorId",
                        column: x => x.CreadorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_EquiposOT_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "EquiposOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_Usuarios_Id",
                        column: x => x.Id,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_InstalacionesOT_InstalacionId",
                        column: x => x.InstalacionId,
                        principalTable: "InstalacionesOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_Poblaciones_PoblacionId",
                        column: x => x.PoblacionId,
                        principalTable: "Poblaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_SubinstalacionesOT_SubInstalacionId",
                        column: x => x.SubInstalacionId,
                        principalTable: "SubinstalacionesOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_TiposOT_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTrabajo_ZonasOT_ZonaId",
                        column: x => x.ZonaId,
                        principalTable: "ZonasOT",
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
                        name: "FK_AnotacionesOT_Usuarios_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnotacionesOT_OrdenesTrabajo_OrdenTrabajoId",
                        column: x => x.OrdenTrabajoId,
                        principalTable: "OrdenesTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    OrdenTrabajoId = table.Column<int>(nullable: true),
                    ConceptoId = table.Column<int>(nullable: true),
                    OperarioId = table.Column<int>(nullable: true),
                    Cantidad = table.Column<double>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Validado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesOT_ConceptosOT_ConceptoId",
                        column: x => x.ConceptoId,
                        principalTable: "ConceptosOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesOT_Usuarios_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesOT_OrdenesTrabajo_OrdenTrabajoId",
                        column: x => x.OrdenTrabajoId,
                        principalTable: "OrdenesTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    RutaFoto = table.Column<string>(maxLength: 250, nullable: false),
                    LecturaId = table.Column<int>(nullable: true),
                    OdenTrabajoId = table.Column<int>(nullable: true),
                    IncidenciaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fotos_Incidencias_IncidenciaId",
                        column: x => x.IncidenciaId,
                        principalTable: "Incidencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fotos_Lecturas_LecturaId",
                        column: x => x.LecturaId,
                        principalTable: "Lecturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fotos_OrdenesTrabajo_OdenTrabajoId",
                        column: x => x.OdenTrabajoId,
                        principalTable: "OrdenesTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InfosAdicionalesOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    LastModified = table.Column<DateTime>(nullable: true),
                    Clave = table.Column<string>(maxLength: 50, nullable: true),
                    Valor = table.Column<string>(maxLength: 250, nullable: true),
                    OrdenTrabajoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfosAdicionalesOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfosAdicionalesOT_OrdenesTrabajo_OrdenTrabajoId",
                        column: x => x.OrdenTrabajoId,
                        principalTable: "OrdenesTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Created", "CreatedBy", "Direccion", "Email", "LastModified", "LastModifiedBy", "Movil", "NIF", "Nombre", "Password", "PathFoto", "Rol", "UserName" },
                values: new object[] { 1, "Temprà Cor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carrer Trobadiners, 40", "jtempra@anoiant.com", null, null, "615051815", "11223344A", "Josep", "123456", "c:\\fotos\\jt.jpg", 0, "jtempra" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Created", "CreatedBy", "Direccion", "Email", "LastModified", "LastModifiedBy", "Movil", "NIF", "Nombre", "Password", "PathFoto", "Rol", "UserName" },
                values: new object[] { 2, "Toful Castanyer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carrer Via Apia, 102-1-4", "jtc@terra.es", null, null, "600112233", "55667788B", "Joan", "123456", "c:\\fotos\\jtc.jpg", 2, "toful" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellidos", "Created", "CreatedBy", "Direccion", "Email", "LastModified", "LastModifiedBy", "Movil", "NIF", "Nombre", "Password", "PathFoto", "Rol", "UserName" },
                values: new object[] { 3, "Font Cagarro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carrer del Montgros, 5", "jfg@terra.es", null, null, "615051814", "00998877X", "Jordi", "123456", "c:\\fotos\\jfg.jpg", 1, "jfont" });

            migrationBuilder.CreateIndex(
                name: "IX_AnotacionesOT_OperarioId",
                table: "AnotacionesOT",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AnotacionesOT_OrdenTrabajoId",
                table: "AnotacionesOT",
                column: "OrdenTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Calles_PoblacionId",
                table: "Calles",
                column: "PoblacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOT_ConceptoId",
                table: "DetallesOT",
                column: "ConceptoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOT_OperarioId",
                table: "DetallesOT",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOT_OrdenTrabajoId",
                table: "DetallesOT",
                column: "OrdenTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiposOT_SubinstalacionId",
                table: "EquiposOT",
                column: "SubinstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_IncidenciaId",
                table: "Fotos",
                column: "IncidenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_LecturaId",
                table: "Fotos",
                column: "LecturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_OdenTrabajoId",
                table: "Fotos",
                column: "OdenTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosLecturas_IncidenciaLecturaId",
                table: "HistoricosLecturas",
                column: "IncidenciaLecturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_OperarioId",
                table: "Incidencias",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_OrigenId",
                table: "Incidencias",
                column: "OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidencias_TipoId",
                table: "Incidencias",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_InfosAdicionalesOT_OrdenTrabajoId",
                table: "InfosAdicionalesOT",
                column: "OrdenTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_InstalacionesOT_PoblacionId",
                table: "InstalacionesOT",
                column: "PoblacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_IncidenciaLecturaId",
                table: "Lecturas",
                column: "IncidenciaLecturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_OperarioId",
                table: "Lecturas",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturas_RutaId",
                table: "Lecturas",
                column: "RutaId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_CalleId",
                table: "OrdenesTrabajo",
                column: "CalleId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_CreadorId",
                table: "OrdenesTrabajo",
                column: "CreadorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_EquipoId",
                table: "OrdenesTrabajo",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_InstalacionId",
                table: "OrdenesTrabajo",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_PoblacionId",
                table: "OrdenesTrabajo",
                column: "PoblacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_SubInstalacionId",
                table: "OrdenesTrabajo",
                column: "SubInstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_TipoId",
                table: "OrdenesTrabajo",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTrabajo_ZonaId",
                table: "OrdenesTrabajo",
                column: "ZonaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubinstalacionesOT_InstalacionId",
                table: "SubinstalacionesOT",
                column: "InstalacionId");

            migrationBuilder.CreateIndex(
                name: "IX_ZonasOT_PoblacionId",
                table: "ZonasOT",
                column: "PoblacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotacionesOT");

            migrationBuilder.DropTable(
                name: "DetallesOT");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "HistoricosLecturas");

            migrationBuilder.DropTable(
                name: "InfosAdicionalesOT");

            migrationBuilder.DropTable(
                name: "ConceptosOT");

            migrationBuilder.DropTable(
                name: "Incidencias");

            migrationBuilder.DropTable(
                name: "Lecturas");

            migrationBuilder.DropTable(
                name: "OrdenesTrabajo");

            migrationBuilder.DropTable(
                name: "TiposOrigenesIncidencias");

            migrationBuilder.DropTable(
                name: "TiposIncidencia");

            migrationBuilder.DropTable(
                name: "TiposIncidenciaLecturas");

            migrationBuilder.DropTable(
                name: "RutasLectura");

            migrationBuilder.DropTable(
                name: "Calles");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "EquiposOT");

            migrationBuilder.DropTable(
                name: "TiposOT");

            migrationBuilder.DropTable(
                name: "ZonasOT");

            migrationBuilder.DropTable(
                name: "SubinstalacionesOT");

            migrationBuilder.DropTable(
                name: "InstalacionesOT");

            migrationBuilder.DropTable(
                name: "Poblaciones");
        }
    }
}
