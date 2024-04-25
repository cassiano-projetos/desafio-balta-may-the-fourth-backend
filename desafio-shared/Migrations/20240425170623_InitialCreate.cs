using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desafio_shared.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "BirthYear", "EyeColor", "Gender", "HairColor", "Height", "Name", "PlanetId", "SkinColor", "Weight" },
                values: new object[] { 1, "19BBY", "Blue", "Male", "Blond", "172", "Luke Skywalker", 0, "Fair", "77" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
