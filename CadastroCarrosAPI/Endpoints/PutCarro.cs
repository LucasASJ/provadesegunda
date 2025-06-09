using CadastroCarrosAPI.Data;
using CadastroCarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCarrosAPI.Endpoints
{
    public static class PutCarro
    {
        public static void MapPutCarro(this WebApplication app)
        {
            app.MapPut("/api/carros/{id}", async (int id, Carro inputCarro, AppDbContext db) =>
            {
                var carro = await db.Carros.FindAsync(id);

                if (carro is null)
                {
                    return Results.NotFound();
                }

                carro.Modelo = inputCarro.Modelo;
                carro.Marca = inputCarro.Marca;
                carro.Ano = inputCarro.Ano;
                carro.Placa = inputCarro.Placa;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });
        }
    }
}