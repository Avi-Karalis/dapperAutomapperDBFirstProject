using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class PersonalAccessTokensMapper : Profile {
        public PersonalAccessTokensMapper() {
            CreateMap<PersonalAccessTokens, PersonalAccessTokensDisplayDto>();
            CreateMap<PersonalAccessTokensCreateDto, PersonalAccessTokens>();
            CreateMap<PersonalAccessTokensUpdateDto, PersonalAccessTokens>();
            CreateMap<PersonalAccessTokensGetDto, PersonalAccessTokens>();
        }
    }
}