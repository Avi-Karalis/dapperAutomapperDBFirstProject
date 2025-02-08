using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsDeletionLogsRepository : GenericRepository<LmsDeletionLogs>, ILmsDeletionLogsRepository {
        public LmsDeletionLogsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}