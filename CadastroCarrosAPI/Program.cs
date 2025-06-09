using CadastroCarrosAPI.Data;
using CadastroCarrosAPI.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext para usar o banco de dados SQLite.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// ADICIONADO: Registra os serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o pipeline de requisições HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    
    // ADICIONADO: Habilita o Swagger e sua UI
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles(); // Permite que o index.html seja a página padrão
app.UseStaticFiles();  // Habilita o uso de arquivos estáticos (HTML, CSS, JS)

// Mapeia todos os endpoints da API
app.MapGetAllCarros();
app.MapGetCarroById();
app.MapPostCarro();
app.MapPutCarro();
app.MapDeleteCarro();

app.Run();