using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsMenusRepository : GenericRepository<LmsMenus>, ILmsMenusRepository {
        public LmsMenusRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}