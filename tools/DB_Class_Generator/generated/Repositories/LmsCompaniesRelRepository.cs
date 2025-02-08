using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCompaniesRelRepository : GenericRepository<LmsCompaniesRel>, ILmsCompaniesRelRepository {
        public LmsCompaniesRelRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}