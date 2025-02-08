using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCoursesService : CrudService<CnvCourses>, ICnvCoursesService {
        public CnvCoursesService(ICnvCoursesRepository repository) : base(repository) {}
    }
}