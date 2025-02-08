using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class DotnetPersonMapper : Profile {
        public DotnetPersonMapper() {
            CreateMap<DotnetPerson, DotnetPersonDisplayDto>();
            CreateMap<DotnetPersonCreateDto, DotnetPerson>();
            CreateMap<DotnetPersonUpdateDto, DotnetPerson>();
            CreateMap<DotnetPersonGetDto, DotnetPerson>();
        }
    }
}