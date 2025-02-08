using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCourseTypesService : CrudService<PclmsCourseTypes>, IPclmsCourseTypesService {
        public PclmsCourseTypesService(IPclmsCourseTypesRepository repository) : base(repository) {}
    }
}