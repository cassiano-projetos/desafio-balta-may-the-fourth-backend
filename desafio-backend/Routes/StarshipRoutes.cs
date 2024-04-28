namespace desafio_backend.Routes
{
    public static class StarshipRoutes
    {
        public static WebApplication MapStarshipRoutes(this WebApplication app)
        {
            app.MapGet("/starship", () => "Hello World Starship!");
            return app;
        }
    }
}
