using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseSectionsRepository : GenericRepository<CnvCourseSections>, ICnvCourseSectionsRepository {
        public CnvCourseSectionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}