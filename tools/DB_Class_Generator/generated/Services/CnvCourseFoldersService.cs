using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseFoldersService : CrudService<CnvCourseFolders>, ICnvCourseFoldersService {
        public CnvCourseFoldersService(ICnvCourseFoldersRepository repository) : base(repository) {}
    }
}