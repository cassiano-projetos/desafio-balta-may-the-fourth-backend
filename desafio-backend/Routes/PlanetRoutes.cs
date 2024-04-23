namespace desafio_backend.Routes
{
    public static class PlanetRoutes
    {
        public static WebApplication MapPlanetRoutes(this WebApplication app)
        {
            app.MapGet("/planet", () => "Hello World Planet!");
            return app;
        }
    }
}
