using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseSessionsMapper : Profile {
        public LmsCourseSessionsMapper() {
            CreateMap<LmsCourseSessions, LmsCourseSessionsDisplayDto>();
            CreateMap<LmsCourseSessionsCreateDto, LmsCourseSessions>();
            CreateMap<LmsCourseSessionsUpdateDto, LmsCourseSessions>();
            CreateMap<LmsCourseSessionsGetDto, LmsCourseSessions>();
        }
    }
}