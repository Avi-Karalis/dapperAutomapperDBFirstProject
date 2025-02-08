using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CompaniesRepository : GenericRepository<Companies>, ICompaniesRepository {
        public CompaniesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}