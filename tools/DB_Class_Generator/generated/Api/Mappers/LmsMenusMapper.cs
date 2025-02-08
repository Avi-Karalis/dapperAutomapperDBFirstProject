using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsMenusMapper : Profile {
        public LmsMenusMapper() {
            CreateMap<LmsMenus, LmsMenusDisplayDto>();
            CreateMap<LmsMenusCreateDto, LmsMenus>();
            CreateMap<LmsMenusUpdateDto, LmsMenus>();
            CreateMap<LmsMenusGetDto, LmsMenus>();
        }
    }
}