using AspNetCoreApp.Models.DTO.Jucatori;
using AspNetCoreApp.Models.Entities;
using AutoMapper;

namespace AspNetCoreApp.Profiles
{
    public class JucatorProfile : Profile
    { 
        public JucatorProfile() 
        {
            /*CreateMap<Jucator, JucatorEditDTO>()
                .ForMember(d => d.IdJucator, s => s.MapFrom(src => src.IdJucator));
                .ForMember*/

            CreateMap<Jucator, JucatorPozaDTO>()
                .ForMember(d => d.IdJucator, s => s.MapFrom(src => src.IdJucator))
                .ForMember(d => d.PozaProfil, s => s.MapFrom(src => src.PozaProfil));

            CreateMap<JucatorDateDTO, Jucator>()
                .ForMember(d => d.Nume, s => s.MapFrom(src => src.Nume))
                .ForMember(d => d.Prenume, s => s.MapFrom(src => src.Prenume))
                .ForMember(d => d.IdTara, s => s.MapFrom(src => src.IdTara))
                .ForMember(d => d.IdEchipa, s => s.MapFrom(src => src.IdEchipa))
                .ForMember(d => d.IdPozitie, s => s.MapFrom(src => src.IdPozitie))
                .ForMember(d => d.DataNasterii, s => s.MapFrom(src => src.DataNasterii))
                .ForMember(d => d.Salariu, s => s.MapFrom(src => src.Salariu));
        }
    }
}