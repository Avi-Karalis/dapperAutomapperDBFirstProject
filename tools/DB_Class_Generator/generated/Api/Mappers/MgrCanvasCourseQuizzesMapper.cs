using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasCourseQuizzesMapper : Profile {
        public MgrCanvasCourseQuizzesMapper() {
            CreateMap<MgrCanvasCourseQuizzes, MgrCanvasCourseQuizzesDisplayDto>();
            CreateMap<MgrCanvasCourseQuizzesCreateDto, MgrCanvasCourseQuizzes>();
            CreateMap<MgrCanvasCourseQuizzesUpdateDto, MgrCanvasCourseQuizzes>();
            CreateMap<MgrCanvasCourseQuizzesGetDto, MgrCanvasCourseQuizzes>();
        }
    }
}