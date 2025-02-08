using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseSectionsService : CrudService<PclmsCourseSections>, IPclmsCourseSectionsService {
        public PclmsCourseSectionsService(IPclmsCourseSectionsRepository repository) : base(repository) {}
    }
}