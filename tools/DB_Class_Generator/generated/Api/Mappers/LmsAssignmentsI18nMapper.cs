using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsAssignmentsI18nMapper : Profile {
        public LmsAssignmentsI18nMapper() {
            CreateMap<LmsAssignmentsI18n, LmsAssignmentsI18nDisplayDto>();
            CreateMap<LmsAssignmentsI18nCreateDto, LmsAssignmentsI18n>();
            CreateMap<LmsAssignmentsI18nUpdateDto, LmsAssignmentsI18n>();
            CreateMap<LmsAssignmentsI18nGetDto, LmsAssignmentsI18n>();
        }
    }
}