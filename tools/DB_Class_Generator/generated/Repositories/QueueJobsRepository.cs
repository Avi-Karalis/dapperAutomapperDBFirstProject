using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class QueueJobsRepository : GenericRepository<QueueJobs>, IQueueJobsRepository {
        public QueueJobsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}