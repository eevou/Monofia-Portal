using Commerce.APIs.Extensions;
using Microsoft.EntityFrameworkCore;
using Monofia_Portal.APIs.Extensions;
using Monofia_Portal.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerSevices();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

builder.Services.AddInfrastructureServices(connectionString);

var app = builder.Build();


using var scope = app.Services.CreateScope(); // Creates a new dependency injection scope.

var services = scope.ServiceProvider;

var loggerFactory = services.GetRequiredService<ILoggerFactory>();

try
{
    var dbContext = services.GetRequiredService<PortalDbContext>();
    await dbContext.Database.MigrateAsync();  // Apply migrations at startup

    await PortalContextSeed.SeedingAsync(dbContext);
}
catch (Exception ex)
{
    var logger = app.Services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An Error Occurs When Applying The Migrations");
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.AddSwaggerServiceMiddlewares();
}
app.UseStatusCodePagesWithRedirects("/errors/{0}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
