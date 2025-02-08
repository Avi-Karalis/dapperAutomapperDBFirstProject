using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class DotnetUploadRepository : GenericRepository<DotnetUpload>, IDotnetUploadRepository {
        public DotnetUploadRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}