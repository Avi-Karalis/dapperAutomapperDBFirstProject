using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsCourseSectionsRepository : GenericRepository<PclmsCourseSections>, IPclmsCourseSectionsRepository {
        public PclmsCourseSectionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}