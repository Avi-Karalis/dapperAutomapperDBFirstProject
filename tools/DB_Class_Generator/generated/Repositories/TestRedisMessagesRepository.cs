using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class TestRedisMessagesRepository : GenericRepository<TestRedisMessages>, ITestRedisMessagesRepository {
        public TestRedisMessagesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}