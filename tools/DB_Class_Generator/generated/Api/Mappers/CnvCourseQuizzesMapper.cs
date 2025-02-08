using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseQuizzesMapper : Profile {
        public CnvCourseQuizzesMapper() {
            CreateMap<CnvCourseQuizzes, CnvCourseQuizzesDisplayDto>();
            CreateMap<CnvCourseQuizzesCreateDto, CnvCourseQuizzes>();
            CreateMap<CnvCourseQuizzesUpdateDto, CnvCourseQuizzes>();
            CreateMap<CnvCourseQuizzesGetDto, CnvCourseQuizzes>();
        }
    }
}