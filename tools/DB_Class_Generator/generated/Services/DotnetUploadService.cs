using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class DotnetUploadService : CrudService<DotnetUpload>, IDotnetUploadService {
        public DotnetUploadService(IDotnetUploadRepository repository) : base(repository) {}
    }
}