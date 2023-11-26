using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerDocument();

builder.Services.AddDbContext<TeamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TeamContext"))
);

var app = builder.Build();

app.UseOpenApi();
app.UseSwaggerUi3();

// scope needed to allow context.Database.Migrate() to work
var scope = app.Services.CreateScope();

TeamContext context = scope.ServiceProvider.GetRequiredService<TeamContext>();

context.Database.Migrate();

app.UseAuthorization();

app.MapControllers();

app.Run();
