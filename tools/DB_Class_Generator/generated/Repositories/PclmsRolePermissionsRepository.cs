using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsRolePermissionsRepository : GenericRepository<PclmsRolePermissions>, IPclmsRolePermissionsRepository {
        public PclmsRolePermissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}