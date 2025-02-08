using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PermissionsRepository : GenericRepository<Permissions>, IPermissionsRepository {
        public PermissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}