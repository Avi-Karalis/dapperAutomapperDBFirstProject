using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MigrationsRepository : GenericRepository<Migrations>, IMigrationsRepository {
        public MigrationsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}