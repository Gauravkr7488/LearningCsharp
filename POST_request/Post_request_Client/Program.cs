var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // Ensure controllers are added

var app = builder.Build();

app.UseAuthorization();
app.MapControllers(); // Ensure controllers are mapped

app.Run();