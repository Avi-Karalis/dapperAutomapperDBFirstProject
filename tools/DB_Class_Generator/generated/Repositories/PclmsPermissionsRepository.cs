using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PclmsPermissionsRepository : GenericRepository<PclmsPermissions>, IPclmsPermissionsRepository {
        public PclmsPermissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}