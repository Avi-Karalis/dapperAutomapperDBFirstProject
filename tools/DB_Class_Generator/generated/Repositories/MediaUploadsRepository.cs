using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MediaUploadsRepository : GenericRepository<MediaUploads>, IMediaUploadsRepository {
        public MediaUploadsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}