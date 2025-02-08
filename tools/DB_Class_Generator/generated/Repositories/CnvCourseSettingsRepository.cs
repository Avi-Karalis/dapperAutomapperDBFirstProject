using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseSettingsRepository : GenericRepository<CnvCourseSettings>, ICnvCourseSettingsRepository {
        public CnvCourseSettingsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}