using System;
using desafio_shared.Data;

namespace desafio_backend.Extensions
{
    public static class BuilderExtensions
    {
        public static void AddArchitectures(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>();
        }
    }
}
