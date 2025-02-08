using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using System.Data;
using System.IO;
namespace AdminPanel.ModelsAndRepository.Repositories {
    public class UploadRepository : GenericRepository<Upload>, IUploadRepository
    {
        private readonly string _uploadFolder;
        public UploadRepository(IDbConnection connection) : base(connection){
            _uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            if (!Directory.Exists(_uploadFolder)){
                Directory.CreateDirectory(_uploadFolder);
            }
        }

        public async Task<bool> UploadFileAsync(Upload file){

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(_uploadFolder, fileName);

            await File.WriteAllBytesAsync(filePath, file.Base64Content);

            return File.Exists(filePath);
        }
    }
}