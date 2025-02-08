using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseUsersMapper : Profile {
        public CnvCourseUsersMapper() {
            CreateMap<CnvCourseUsers, CnvCourseUsersDisplayDto>();
            CreateMap<CnvCourseUsersCreateDto, CnvCourseUsers>();
            CreateMap<CnvCourseUsersUpdateDto, CnvCourseUsers>();
            CreateMap<CnvCourseUsersGetDto, CnvCourseUsers>();
        }
    }
}