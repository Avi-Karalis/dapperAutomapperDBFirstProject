using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseFilesRepository : GenericRepository<CnvCourseFiles>, ICnvCourseFilesRepository {
        public CnvCourseFilesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}