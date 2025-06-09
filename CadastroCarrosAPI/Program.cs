using CadastroCarrosAPI.Data;
using CadastroCarrosAPI.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext para usar o banco de dados SQLite.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseDefaultFiles(); // Permite que o index.html seja a página padrão
app.UseStaticFiles();  // Habilita o uso de arquivos estáticos (HTML, CSS, JS)

// Mapeia todos os endpoints da API
app.MapGetAllCarros();
app.MapGetCarroById();
app.MapPostCarro();
app.MapDeleteCarro();

app.Run();