using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasAccountUsersMapper : Profile {
        public MgrCanvasAccountUsersMapper() {
            CreateMap<MgrCanvasAccountUsers, MgrCanvasAccountUsersDisplayDto>();
            CreateMap<MgrCanvasAccountUsersCreateDto, MgrCanvasAccountUsers>();
            CreateMap<MgrCanvasAccountUsersUpdateDto, MgrCanvasAccountUsers>();
            CreateMap<MgrCanvasAccountUsersGetDto, MgrCanvasAccountUsers>();
        }
    }
}