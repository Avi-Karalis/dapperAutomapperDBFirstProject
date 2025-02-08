using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class CnvCourseEnrollmentsUsersMapper : Profile {
        public CnvCourseEnrollmentsUsersMapper() {
            CreateMap<CnvCourseEnrollmentsUsers, CnvCourseEnrollmentsUsersDisplayDto>();
            CreateMap<CnvCourseEnrollmentsUsersCreateDto, CnvCourseEnrollmentsUsers>();
            CreateMap<CnvCourseEnrollmentsUsersUpdateDto, CnvCourseEnrollmentsUsers>();
            CreateMap<CnvCourseEnrollmentsUsersGetDto, CnvCourseEnrollmentsUsers>();
        }
    }
}