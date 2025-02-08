using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseDiscussionTopicsMapper : Profile {
        public CnvCourseDiscussionTopicsMapper() {
            CreateMap<CnvCourseDiscussionTopics, CnvCourseDiscussionTopicsDisplayDto>();
            CreateMap<CnvCourseDiscussionTopicsCreateDto, CnvCourseDiscussionTopics>();
            CreateMap<CnvCourseDiscussionTopicsUpdateDto, CnvCourseDiscussionTopics>();
            CreateMap<CnvCourseDiscussionTopicsGetDto, CnvCourseDiscussionTopics>();
        }
    }
}