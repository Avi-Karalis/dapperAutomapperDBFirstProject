using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PclmsCoursesService : CrudService<PclmsCourses>, IPclmsCoursesService {
        public PclmsCoursesService(IPclmsCoursesRepository repository) : base(repository) {}
    }
}