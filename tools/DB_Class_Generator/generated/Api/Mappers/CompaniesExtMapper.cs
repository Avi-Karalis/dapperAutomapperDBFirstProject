using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CompaniesExtMapper : Profile {
        public CompaniesExtMapper() {
            CreateMap<CompaniesExt, CompaniesExtDisplayDto>();
            CreateMap<CompaniesExtCreateDto, CompaniesExt>();
            CreateMap<CompaniesExtUpdateDto, CompaniesExt>();
            CreateMap<CompaniesExtGetDto, CompaniesExt>();
        }
    }
}