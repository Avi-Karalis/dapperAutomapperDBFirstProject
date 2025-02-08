using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsPositionRolesRepository : GenericRepository<LmsPositionRoles>, ILmsPositionRolesRepository {
        public LmsPositionRolesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}