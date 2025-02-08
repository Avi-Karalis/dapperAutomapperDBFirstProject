using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseQuizzesMapper : Profile {
        public PclmsCourseQuizzesMapper() {
            CreateMap<PclmsCourseQuizzes, PclmsCourseQuizzesDisplayDto>();
            CreateMap<PclmsCourseQuizzesCreateDto, PclmsCourseQuizzes>();
            CreateMap<PclmsCourseQuizzesUpdateDto, PclmsCourseQuizzes>();
            CreateMap<PclmsCourseQuizzesGetDto, PclmsCourseQuizzes>();
        }
    }
}