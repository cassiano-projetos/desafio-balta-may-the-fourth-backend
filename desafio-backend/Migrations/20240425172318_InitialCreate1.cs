using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_shared.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Episode", "OpeningCrawl", "Producer", "ReleaseDate", "Title" },
                values: new object[] { 1, "George Lucas", 4, "It is a period of civil war.", "Gary Kurtz, Rick McCallum", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode IV - A New Hope" });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Id", "Climate", "Diameter", "Gravity", "Name", "OrbitalPeriod", "Population", "RotationPeriod", "SurfaceWater", "Terrain" },
                values: new object[] { 1, "Arid", "10465", "1 standard", "Tatooine", "304", "200000", "23", "1", "Desert" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
