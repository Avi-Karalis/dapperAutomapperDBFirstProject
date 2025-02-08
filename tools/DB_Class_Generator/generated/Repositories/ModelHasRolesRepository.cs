using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class ModelHasRolesRepository : GenericRepository<ModelHasRoles>, IModelHasRolesRepository {
        public ModelHasRolesRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}