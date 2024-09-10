using System.Text.Json.Serialization;

using APICatalogo.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

//Referencia Ciclica
builder.Services.AddControllers().AddJsonOptions(options => 
    options.JsonSerializerOptions
    .ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<APIWebContext>(options =>
    options.UseMySql(mySqlConnection ,ServerVersion.AutoDetect(mySqlConnection)));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
