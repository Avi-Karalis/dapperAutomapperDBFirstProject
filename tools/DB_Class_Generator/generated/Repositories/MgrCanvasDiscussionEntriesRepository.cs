using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasDiscussionEntriesRepository : GenericRepository<MgrCanvasDiscussionEntries>, IMgrCanvasDiscussionEntriesRepository {
        public MgrCanvasDiscussionEntriesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}