using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class RoleHasPermissionsRepository : GenericRepository<RoleHasPermissions>, IRoleHasPermissionsRepository {
        public RoleHasPermissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}