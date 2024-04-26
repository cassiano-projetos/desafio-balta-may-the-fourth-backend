﻿namespace desafio_backend.ViewModels.PlanetViewModel
{
    public class PlanetViewModel
    {
        public PlanetViewModel(string name, string rotationPeriod, string orbitalPeriod, string diameter, string climate, string gravity, string terrain, string surfaceWater, string population)
        {
            Name = name;
            RotationPeriod = rotationPeriod;
            OrbitalPeriod = orbitalPeriod;
            Diameter = diameter;
            Climate = climate;
            Gravity = gravity;
            Terrain = terrain;
            SurfaceWater = surfaceWater;
            Population = population;
        }

        public string Name { get; private set; } = string.Empty;
        public string RotationPeriod { get; private set; } = string.Empty;
        public string OrbitalPeriod { get; private set; } = string.Empty;
        public string Diameter { get; private set; } = string.Empty;
        public string Climate { get; private set; } = string.Empty;
        public string Gravity { get; private set; } = string.Empty;
        public string Terrain { get; private set; } = string.Empty;
        public string SurfaceWater { get; private set; } = string.Empty;
        public string Population { get; private set; } = string.Empty;
    }
}