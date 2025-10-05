// Demo/Program.cs

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Entry point for the application
var builder = WebApplication.CreateBuilder(args);

// Configure the database context to use SQL Server with a connection string from appsettings.json
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add controllers to the service collection
builder.Services.AddControllers();

// Build and run the application
var app = builder.Build();
app.MapControllers();
app.Run();
