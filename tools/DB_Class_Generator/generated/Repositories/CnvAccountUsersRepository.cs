using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvAccountUsersRepository : GenericRepository<CnvAccountUsers>, ICnvAccountUsersRepository {
        public CnvAccountUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}