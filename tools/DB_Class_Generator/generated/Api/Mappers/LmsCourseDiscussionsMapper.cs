using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class LmsCourseDiscussionsMapper : Profile {
        public LmsCourseDiscussionsMapper() {
            CreateMap<LmsCourseDiscussions, LmsCourseDiscussionsDisplayDto>();
            CreateMap<LmsCourseDiscussionsCreateDto, LmsCourseDiscussions>();
            CreateMap<LmsCourseDiscussionsUpdateDto, LmsCourseDiscussions>();
            CreateMap<LmsCourseDiscussionsGetDto, LmsCourseDiscussions>();
        }
    }
}