using AutoMapper;
using Menofia_Portal.Core.Entities;
using Monofia_Portal.Services.DTOs;

namespace Monofia_Portal.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PortalNews, NewsDto>()
                .ForMember(
                    dest => dest.Header,
                    Opt => Opt
                .MapFrom(S => S.Translations.Select(t => t.Header).ToList()))
                .ForMember(
                    dest => dest.Abbreviation,
                    Opt => Opt.MapFrom(S => S.Translations.Select(t => t.Abbreviation).ToList()));

        }
    }
}
