using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;
namespace AdminPanel.Service.Services{
    public class UploadService : CrudService<Upload>, IUploadService{
        private readonly IUploadRepository _uploadRepository;
        public UploadService(IUploadRepository uploadRepository) : base(uploadRepository){
            _uploadRepository = uploadRepository;
        }

        public override async Task<Upload> CreateAsync(Upload entity){
            bool created = await _uploadRepository.UploadFileAsync(entity);
            if (created){
                return await _repository.CreateAsync(entity);
            }
            throw new Exception("File not uploaded");
        }
    }
}