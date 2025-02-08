using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CompanyUsersRepository : GenericRepository<CompanyUsers>, ICompanyUsersRepository {
        public CompanyUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}