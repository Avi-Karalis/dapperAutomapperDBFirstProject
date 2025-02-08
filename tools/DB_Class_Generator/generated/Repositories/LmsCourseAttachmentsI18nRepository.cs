using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseAttachmentsI18nRepository : GenericRepository<LmsCourseAttachmentsI18n>, ILmsCourseAttachmentsI18nRepository {
        public LmsCourseAttachmentsI18nRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}