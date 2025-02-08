using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class SectionContentsRepository : GenericRepository<SectionContents>, ISectionContentsRepository {
        public SectionContentsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}