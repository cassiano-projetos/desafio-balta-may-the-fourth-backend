using desafio_backend;

var builder = WebApplication.CreateBuilder(args);
builder.AddArchitectures();

builder.Services.AddCors(
    x=>x.AddPolicy(
        Configuration.CorsPolicyName,
        policy 
            => 
            policy.WithOrigins([Configuration.BackendUrl,Configuration.FrontendUrl])
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
        ));

var app = builder.Build();

app.UseCors(Configuration.CorsPolicyName);
app.MapRoutes();
app.UseArchitectures();

app.Run();
