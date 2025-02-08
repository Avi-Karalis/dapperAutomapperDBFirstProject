using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseAssetsService : CrudService<LmsCourseAssets>, ILmsCourseAssetsService {
        public LmsCourseAssetsService(ILmsCourseAssetsRepository repository) : base(repository) {}
    }
}