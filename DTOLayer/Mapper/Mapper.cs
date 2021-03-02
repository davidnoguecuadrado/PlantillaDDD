using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;

namespace DTOLayer.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() {

            //Mapeas las DTO
            CreateMap<CasaDTO, Casa>();
            CreateMap<Casa ,CasaDTO>();
        }
    }
}
