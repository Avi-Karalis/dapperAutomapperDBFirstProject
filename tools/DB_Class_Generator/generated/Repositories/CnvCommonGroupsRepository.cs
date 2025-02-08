using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvCommonGroupsRepository : GenericRepository<CnvCommonGroups>, ICnvCommonGroupsRepository {
        public CnvCommonGroupsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}