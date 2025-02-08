using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsAssignmentsI18nRepository : GenericRepository<LmsAssignmentsI18n>, ILmsAssignmentsI18nRepository {
        public LmsAssignmentsI18nRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}