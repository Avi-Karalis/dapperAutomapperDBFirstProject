using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MediaUploadsService : CrudService<MediaUploads>, IMediaUploadsService {
        public MediaUploadsService(IMediaUploadsRepository repository) : base(repository) {}
    }
}