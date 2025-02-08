using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseDiscussionTopicsRepository : GenericRepository<CnvCourseDiscussionTopics>, ICnvCourseDiscussionTopicsRepository {
        public CnvCourseDiscussionTopicsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}