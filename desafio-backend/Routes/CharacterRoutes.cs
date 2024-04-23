namespace desafio_backend.Routes
{
    public static class CharacterRoutes
    {
        public static WebApplication MapCharacterRoutes(this WebApplication app)
        {
            app.MapGet("/character", () => "Hello World Character!");
            return app;
        }
    }
}
