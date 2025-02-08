using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CompaniesMapper : Profile {
        public CompaniesMapper() {
            CreateMap<Companies, CompaniesDisplayDto>();
            CreateMap<CompaniesCreateDto, Companies>();
            CreateMap<CompaniesUpdateDto, Companies>();
            CreateMap<CompaniesGetDto, Companies>();
        }
    }
}