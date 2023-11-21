var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerDocument();

var app = builder.Build();

app.UseOpenApi();
app.UseSwaggerUi3();

app.UseAuthorization();

app.MapControllers();

app.Run();
