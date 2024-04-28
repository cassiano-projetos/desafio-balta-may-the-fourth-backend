using AutoMapper;

namespace desafio_backend.AutoMapper
{
    public class AutoMapperService
    {
        private readonly IMapper _mapper;

        public AutoMapperService(IMapper mapper)
        {
            _mapper = mapper;
        }


    }
}
