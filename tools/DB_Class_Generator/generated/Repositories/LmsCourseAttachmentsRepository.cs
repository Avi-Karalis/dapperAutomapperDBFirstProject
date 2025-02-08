using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsCourseAttachmentsRepository : GenericRepository<LmsCourseAttachments>, ILmsCourseAttachmentsRepository {
        public LmsCourseAttachmentsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}