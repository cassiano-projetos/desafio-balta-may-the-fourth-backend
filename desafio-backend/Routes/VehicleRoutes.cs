namespace desafio_backend.Routes
{
    public static class VehicleRoutes
    {
        public static WebApplication MapVehicleRoutes(this WebApplication app)
        {
            app.MapGet("/vehicle", () => "Hello World Vehicle!");
            return app;
        }
    }
}
