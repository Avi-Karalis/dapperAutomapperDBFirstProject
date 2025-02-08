using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PclmsCourseUsersMapper : Profile {
        public PclmsCourseUsersMapper() {
            CreateMap<PclmsCourseUsers, PclmsCourseUsersDisplayDto>();
            CreateMap<PclmsCourseUsersCreateDto, PclmsCourseUsers>();
            CreateMap<PclmsCourseUsersUpdateDto, PclmsCourseUsers>();
            CreateMap<PclmsCourseUsersGetDto, PclmsCourseUsers>();
        }
    }
}