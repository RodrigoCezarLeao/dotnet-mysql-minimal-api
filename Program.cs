using MySql.Data.MySqlClient;
using dotnet_mysql_minimal_api;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();




///////////////////// MEXER S� AQUI DENTRO (DEFINIR ENDPOINTS)

var obterConexao = () =>
{
    // Criar a conex�o
    var connectionString = builder.Configuration["MySqlConnection"];
    var conexao = new DatabaseService(connectionString);
    return conexao;
};


app.MapPost("/LoginVoluntario", (LoginRequest payload) =>
{
    // Criar a conex�o
    var conn = obterConexao();

    // L�gica do endpoint
    var estaLogadoComSucesso = conn.Login(payload);

    // Retorno
    return Results.Ok(estaLogadoComSucesso);
});






app.MapGet("/ObterTodosVoluntarios", () => {
    // Criar a conex�o
    var conn = obterConexao();

    // L�gica do endpoint
    var data = conn.ObterVoluntarios();

    // Retorno
    return Results.Ok(data);
});





















/////////////////////




app.Run();

