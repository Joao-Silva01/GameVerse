using BackGameVerse.Data;
using BackGameVerse.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GameVerseContext>(x => x.UseInMemoryDatabase("GameVerse"));

builder.Services.AddScoped<Seeding>();
builder.Services.AddScoped<GameService>();
builder.Services.AddScoped<GameListService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using(var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<GameVerseContext>();
        var seedimgDb = new Seeding(context);
        seedimgDb.Seed();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
