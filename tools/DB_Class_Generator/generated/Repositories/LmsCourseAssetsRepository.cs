using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseAssetsRepository : GenericRepository<LmsCourseAssets>, ILmsCourseAssetsRepository {
        public LmsCourseAssetsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}