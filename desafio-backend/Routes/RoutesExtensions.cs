namespace desafio_backend.Routes
{
    public static class RoutesExtensions
    {
        public static void MapRoutes(this WebApplication app)
        {
            app
                .MapCharacterRoutes()
                .MapVehicleRoutes()
                .MapMovieRoutes()
                .MapPlanetRoutes()
                .MapStarshipRoutes();
        }
    }
}
