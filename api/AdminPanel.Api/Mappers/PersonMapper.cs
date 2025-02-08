using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers
{
    public class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<Person, PersonDisplayDto>();
            CreateMap<PersonCreateDto, Person>();
            CreateMap<PersonUpdateDto, Person>();
            CreateMap<PersonGetDto, Person>();
        }
    }
}