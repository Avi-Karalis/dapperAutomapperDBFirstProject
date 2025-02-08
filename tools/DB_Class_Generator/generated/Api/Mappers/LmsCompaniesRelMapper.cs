using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCompaniesRelMapper : Profile {
        public LmsCompaniesRelMapper() {
            CreateMap<LmsCompaniesRel, LmsCompaniesRelDisplayDto>();
            CreateMap<LmsCompaniesRelCreateDto, LmsCompaniesRel>();
            CreateMap<LmsCompaniesRelUpdateDto, LmsCompaniesRel>();
            CreateMap<LmsCompaniesRelGetDto, LmsCompaniesRel>();
        }
    }
}