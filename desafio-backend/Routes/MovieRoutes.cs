namespace desafio_backend.Routes
{
    public static class MovieRoutes
    {
        public static WebApplication MapMovieRoutes(this WebApplication app)
        {
            app.MapGet("/movie", () => "Hello World Movie!");
            return app;
        }
    }
}
