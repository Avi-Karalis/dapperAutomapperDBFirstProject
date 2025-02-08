using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseSectionsService : CrudService<CnvCourseSections>, ICnvCourseSectionsService {
        public CnvCourseSectionsService(ICnvCourseSectionsRepository repository) : base(repository) {}
    }
}