using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;
using AutoMapper;
namespace AdminPanel.Api.Mappers {
    public class UserMapper : Profile {
        public UserMapper() {
            CreateMap<User, UserDisplayDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
            CreateMap<UserGetDto, User>();
        }
    }
}