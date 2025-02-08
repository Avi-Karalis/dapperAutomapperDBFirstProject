using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseTaxonomiesRepository : GenericRepository<LmsCourseTaxonomies>, ILmsCourseTaxonomiesRepository {
        public LmsCourseTaxonomiesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}