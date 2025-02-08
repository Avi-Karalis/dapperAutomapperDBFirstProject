using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsTablesMapper : Profile {
        public LmsTablesMapper() {
            CreateMap<LmsTables, LmsTablesDisplayDto>();
            CreateMap<LmsTablesCreateDto, LmsTables>();
            CreateMap<LmsTablesUpdateDto, LmsTables>();
            CreateMap<LmsTablesGetDto, LmsTables>();
        }
    }
}