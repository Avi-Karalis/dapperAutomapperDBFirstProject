using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class ModelHasPermissionsRepository : GenericRepository<ModelHasPermissions>, IModelHasPermissionsRepository {
        public ModelHasPermissionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}