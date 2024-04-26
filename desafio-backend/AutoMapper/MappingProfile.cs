using AutoMapper;
using desafio_backend.ViewModels;
using desafio_backend.ViewModels.MovieViewModel;
using desafio_backend.ViewModels.PlanetViewModel;
using desafio_shared.Entities;

namespace desafio_backend.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Movie, MovieViewModel>();
            CreateMap<Character, CharacterViewModel>();

            CreateMap<Planet, PlanetViewModel>();
            CreateMap<Vehicle, VehicleViewModel>();
            CreateMap<Starship, StarshipViewModel>();

        }
    }
}
