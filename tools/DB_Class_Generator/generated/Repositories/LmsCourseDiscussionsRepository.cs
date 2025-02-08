using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseDiscussionsRepository : GenericRepository<LmsCourseDiscussions>, ILmsCourseDiscussionsRepository {
        public LmsCourseDiscussionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}