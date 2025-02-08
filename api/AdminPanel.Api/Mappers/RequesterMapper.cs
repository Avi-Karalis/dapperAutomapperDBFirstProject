using AdminPanel.Api.Models;
using AdminPanel.ModelsAndRepository.Models;
using AutoMapper;
namespace AdminPanel.Api.Mappers {
    public class RequesterMapper : Profile {
        public RequesterMapper() {
            CreateMap<RequesterRequest, RequesterResponse>();
            CreateMap<RequesterResponse,RequesterRequest>();
        }
    }
}
