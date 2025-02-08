using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseDiscussionTopicsEntriesMapper : Profile {
        public CnvCourseDiscussionTopicsEntriesMapper() {
            CreateMap<CnvCourseDiscussionTopicsEntries, CnvCourseDiscussionTopicsEntriesDisplayDto>();
            CreateMap<CnvCourseDiscussionTopicsEntriesCreateDto, CnvCourseDiscussionTopicsEntries>();
            CreateMap<CnvCourseDiscussionTopicsEntriesUpdateDto, CnvCourseDiscussionTopicsEntries>();
            CreateMap<CnvCourseDiscussionTopicsEntriesGetDto, CnvCourseDiscussionTopicsEntries>();
        }
    }
}