using AutoMapper;
using desafio_backend.ViewModels.MovieViewModel;
using desafio_shared.Entities;

namespace desafio_backend.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Movie, MovieViewModel>();
        }
    }
}
