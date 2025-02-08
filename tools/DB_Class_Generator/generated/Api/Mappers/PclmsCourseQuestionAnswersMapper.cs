using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseQuestionAnswersMapper : Profile {
        public PclmsCourseQuestionAnswersMapper() {
            CreateMap<PclmsCourseQuestionAnswers, PclmsCourseQuestionAnswersDisplayDto>();
            CreateMap<PclmsCourseQuestionAnswersCreateDto, PclmsCourseQuestionAnswers>();
            CreateMap<PclmsCourseQuestionAnswersUpdateDto, PclmsCourseQuestionAnswers>();
            CreateMap<PclmsCourseQuestionAnswersGetDto, PclmsCourseQuestionAnswers>();
        }
    }
}