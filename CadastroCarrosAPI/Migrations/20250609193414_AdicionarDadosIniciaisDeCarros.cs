using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadastroCarrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisDeCarros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carros",
                columns: new[] { "Id", "Ano", "Marca", "Modelo", "Placa" },
                values: new object[,]
                {
                    { 1, 1978, "Volkswagen", "Fusca", "ABC-1234" },
                    { 2, 2010, "Fiat", "Uno", "DEF-5678" },
                    { 3, 2020, "Chevrolet", "Onix", "GHI-9012" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carros",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
