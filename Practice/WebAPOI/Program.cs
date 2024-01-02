
using BLL;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/Pranay", () => "Who are You ?");

app.MapGet("/Data", () =>
{
    List<Employee> emp = new List<Employee>();
    emp = DBManager.getAll();
    return emp;
});

app.MapGet("/singleData/{id}", (int id) =>
{
    Employee em = Catalog.getData(id);
    return em;
});
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
