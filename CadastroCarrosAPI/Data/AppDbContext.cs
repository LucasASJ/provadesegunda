using CadastroCarrosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCarrosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Carro> Carros { get; set; }

        // MUDANÇA: Adicionado este método para popular o banco
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>().HasData(
                new Carro { Id = 1, Modelo = "Fusca", Marca = "Volkswagen", Ano = 1978, Placa = "ABC-1234" },
                new Carro { Id = 2, Modelo = "Uno", Marca = "Fiat", Ano = 2010, Placa = "DEF-5678" },
                new Carro { Id = 3, Modelo = "Onix", Marca = "Chevrolet", Ano = 2020, Placa = "GHI-9012" }
            );
        }
    }
}