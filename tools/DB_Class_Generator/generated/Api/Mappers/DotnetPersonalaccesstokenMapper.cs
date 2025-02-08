using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class DotnetPersonalaccesstokenMapper : Profile {
        public DotnetPersonalaccesstokenMapper() {
            CreateMap<DotnetPersonalaccesstoken, DotnetPersonalaccesstokenDisplayDto>();
            CreateMap<DotnetPersonalaccesstokenCreateDto, DotnetPersonalaccesstoken>();
            CreateMap<DotnetPersonalaccesstokenUpdateDto, DotnetPersonalaccesstoken>();
            CreateMap<DotnetPersonalaccesstokenGetDto, DotnetPersonalaccesstoken>();
        }
    }
}