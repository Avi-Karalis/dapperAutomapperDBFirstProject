using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvSubmissionsRepository : GenericRepository<CnvSubmissions>, ICnvSubmissionsRepository {
        public CnvSubmissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}