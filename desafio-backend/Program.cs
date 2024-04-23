var builder = WebApplication.CreateBuilder(args);
builder.AddArchitectures();

var app = builder.Build();
app.MapRoutes();
app.UseArchitectures();

app.Run();
