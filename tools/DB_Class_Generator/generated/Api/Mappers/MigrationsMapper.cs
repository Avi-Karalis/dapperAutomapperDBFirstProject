using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class MigrationsMapper : Profile {
        public MigrationsMapper() {
            CreateMap<Migrations, MigrationsDisplayDto>();
            CreateMap<MigrationsCreateDto, Migrations>();
            CreateMap<MigrationsUpdateDto, Migrations>();
            CreateMap<MigrationsGetDto, Migrations>();
        }
    }
}