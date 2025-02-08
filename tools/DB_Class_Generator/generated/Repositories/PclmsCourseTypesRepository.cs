using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseTypesRepository : GenericRepository<PclmsCourseTypes>, IPclmsCourseTypesRepository {
        public PclmsCourseTypesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}