using Beerwar.Database;
using Beerwar.Services;
using Beerwar.Services.Interfaces;
using Beerwar.Services.Interfaces.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
builder.Services.AddScoped<IRatingSystem, EloSystem>();
builder.Services.AddScoped<IMatchMaking, MatchMaker>();

builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();

builder.Services.AddDbContext<BeerwarContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

//app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseOpenApi();

app.Run();
