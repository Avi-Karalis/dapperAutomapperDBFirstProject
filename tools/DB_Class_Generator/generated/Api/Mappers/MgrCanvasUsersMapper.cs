using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MgrCanvasUsersMapper : Profile {
        public MgrCanvasUsersMapper() {
            CreateMap<MgrCanvasUsers, MgrCanvasUsersDisplayDto>();
            CreateMap<MgrCanvasUsersCreateDto, MgrCanvasUsers>();
            CreateMap<MgrCanvasUsersUpdateDto, MgrCanvasUsers>();
            CreateMap<MgrCanvasUsersGetDto, MgrCanvasUsers>();
        }
    }
}