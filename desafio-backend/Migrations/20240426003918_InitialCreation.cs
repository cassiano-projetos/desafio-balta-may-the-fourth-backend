using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Episode = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false),
                    OpeningCrawl = table.Column<string>(type: "TEXT", maxLength: 7000, nullable: false),
                    Director = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Producer = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR", maxLength: 100, nullable: false),
                    RotationPeriod = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    OrbitalPeriod = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Diameter = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Climate = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Gravity = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Terrain = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    SurfaceWater = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Population = table.Column<string>(type: "NVARCHAR", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR", maxLength: 100, nullable: false),
                    Model = table.Column<string>(type: "NVARCHAR", maxLength: 15, nullable: false),
                    Manufacturer = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    CostInCredits = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Length = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    MaxSpeed = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Crew = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Passengers = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    CargoCapacity = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    HyperdriveRating = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Mglt = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    Consumables = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false),
                    Class = table.Column<string>(type: "NVARCHAR", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CostInCredits = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Length = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MaxSpeed = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Crew = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Passengers = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CargoCapacity = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Consumables = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Class = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "NVARCHAR", maxLength: 100, nullable: false),
                    Height = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    Weight = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    HairColor = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    SkinColor = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    EyeColor = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    BirthYear = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    Gender = table.Column<string>(type: "NVARCHAR", maxLength: 10, nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePlanets",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanetId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlanets", x => new { x.MovieId, x.PlanetId });
                    table.ForeignKey(
                        name: "FK_MoviePlanets_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePlanets_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieStarships",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    StarshipId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieStarships", x => new { x.MovieId, x.StarshipId });
                    table.ForeignKey(
                        name: "FK_MovieStarships_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieStarships_Starships_StarshipId",
                        column: x => x.StarshipId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieVehicles",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVehicles", x => new { x.MovieId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_MovieVehicles_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieVehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCharacter",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCharacter", x => new { x.MovieId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_MovieCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCharacter_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlanetId",
                table: "Characters",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacter_CharacterId",
                table: "MovieCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePlanets_PlanetId",
                table: "MoviePlanets",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieStarships_StarshipId",
                table: "MovieStarships",
                column: "StarshipId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieVehicles_VehicleId",
                table: "MovieVehicles",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCharacter");

            migrationBuilder.DropTable(
                name: "MoviePlanets");

            migrationBuilder.DropTable(
                name: "MovieStarships");

            migrationBuilder.DropTable(
                name: "MovieVehicles");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
