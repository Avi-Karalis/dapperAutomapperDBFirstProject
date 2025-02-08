using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCourseFoldersRepository : GenericRepository<CnvCourseFolders>, ICnvCourseFoldersRepository {
        public CnvCourseFoldersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}