using AutoMapper;
using AdminPanel.Api.DTOs;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.Api.Mappers {
    public class TestRedisMessagesMapper : Profile {
        public TestRedisMessagesMapper() {
            CreateMap<TestRedisMessages, TestRedisMessagesDisplayDto>();
            CreateMap<TestRedisMessagesCreateDto, TestRedisMessages>();
            CreateMap<TestRedisMessagesUpdateDto, TestRedisMessages>();
            CreateMap<TestRedisMessagesGetDto, TestRedisMessages>();
        }
    }
}