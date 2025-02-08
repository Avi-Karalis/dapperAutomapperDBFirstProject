using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CoursesService : CrudService<Courses>, ICoursesService {
        public CoursesService(ICoursesRepository repository) : base(repository) {}
    }
}