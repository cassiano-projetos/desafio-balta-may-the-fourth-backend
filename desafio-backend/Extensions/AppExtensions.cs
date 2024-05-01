using AutoMapper;

namespace desafio_backend.Extensions
{
    public static class AppExtensions
    {
        public static void UseArchitectures(this WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Balta");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
