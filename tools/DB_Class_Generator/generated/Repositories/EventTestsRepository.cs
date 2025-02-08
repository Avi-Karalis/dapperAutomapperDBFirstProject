using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class EventTestsRepository : GenericRepository<EventTests>, IEventTestsRepository {
        public EventTestsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}