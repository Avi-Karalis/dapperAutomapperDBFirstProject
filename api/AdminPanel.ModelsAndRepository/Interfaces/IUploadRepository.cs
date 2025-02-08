using AdminPanel.ModelsAndRepository.Models;
namespace AdminPanel.ModelsAndRepository.Interfaces{
    public interface IUploadRepository : IGenericRepository<Upload>{
        public Task<bool> UploadFileAsync(Upload file);
    }
}