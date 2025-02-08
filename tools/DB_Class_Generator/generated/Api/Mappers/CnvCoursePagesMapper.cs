using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCoursePagesMapper : Profile {
        public CnvCoursePagesMapper() {
            CreateMap<CnvCoursePages, CnvCoursePagesDisplayDto>();
            CreateMap<CnvCoursePagesCreateDto, CnvCoursePages>();
            CreateMap<CnvCoursePagesUpdateDto, CnvCoursePages>();
            CreateMap<CnvCoursePagesGetDto, CnvCoursePages>();
        }
    }
}