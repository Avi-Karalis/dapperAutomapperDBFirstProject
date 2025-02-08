using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasDiscussionTopicsRepository : GenericRepository<MgrCanvasDiscussionTopics>, IMgrCanvasDiscussionTopicsRepository {
        public MgrCanvasDiscussionTopicsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}