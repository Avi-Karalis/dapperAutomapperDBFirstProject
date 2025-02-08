using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class SectionsRepository : GenericRepository<Sections>, ISectionsRepository {
        public SectionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}