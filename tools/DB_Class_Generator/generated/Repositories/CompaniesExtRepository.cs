using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CompaniesExtRepository : GenericRepository<CompaniesExt>, ICompaniesExtRepository {
        public CompaniesExtRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}