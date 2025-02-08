using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class TestRedisMessagesService : CrudService<TestRedisMessages>, ITestRedisMessagesService {
        public TestRedisMessagesService(ITestRedisMessagesRepository repository) : base(repository) {}
    }
}