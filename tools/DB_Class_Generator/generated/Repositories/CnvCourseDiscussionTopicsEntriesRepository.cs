using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseDiscussionTopicsEntriesRepository : GenericRepository<CnvCourseDiscussionTopicsEntries>, ICnvCourseDiscussionTopicsEntriesRepository {
        public CnvCourseDiscussionTopicsEntriesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}