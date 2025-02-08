using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseTypesMapper : Profile {
        public PclmsCourseTypesMapper() {
            CreateMap<PclmsCourseTypes, PclmsCourseTypesDisplayDto>();
            CreateMap<PclmsCourseTypesCreateDto, PclmsCourseTypes>();
            CreateMap<PclmsCourseTypesUpdateDto, PclmsCourseTypes>();
            CreateMap<PclmsCourseTypesGetDto, PclmsCourseTypes>();
        }
    }
}