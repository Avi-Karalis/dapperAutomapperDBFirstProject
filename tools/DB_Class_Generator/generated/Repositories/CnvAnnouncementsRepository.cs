using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class CnvAnnouncementsRepository : GenericRepository<CnvAnnouncements>, ICnvAnnouncementsRepository {
        public CnvAnnouncementsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}