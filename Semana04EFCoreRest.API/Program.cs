using Microsoft.EntityFrameworkCore;
using Semana04EFCoreRest.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Get the connection string
var connectionString = builder.Configuration.GetConnectionString("DevConnection");
//Add DbContext

builder.Services.AddDbContext<MundialQatar2022SinPeruContext>
    (options => options.UseSqlServer(connectionString));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
