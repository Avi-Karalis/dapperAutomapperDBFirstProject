using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCompanyContractsRepository : GenericRepository<LmsCompanyContracts>, ILmsCompanyContractsRepository {
        public LmsCompanyContractsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}