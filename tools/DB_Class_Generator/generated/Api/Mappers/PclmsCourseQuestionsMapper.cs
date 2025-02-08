using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseQuestionsMapper : Profile {
        public PclmsCourseQuestionsMapper() {
            CreateMap<PclmsCourseQuestions, PclmsCourseQuestionsDisplayDto>();
            CreateMap<PclmsCourseQuestionsCreateDto, PclmsCourseQuestions>();
            CreateMap<PclmsCourseQuestionsUpdateDto, PclmsCourseQuestions>();
            CreateMap<PclmsCourseQuestionsGetDto, PclmsCourseQuestions>();
        }
    }
}