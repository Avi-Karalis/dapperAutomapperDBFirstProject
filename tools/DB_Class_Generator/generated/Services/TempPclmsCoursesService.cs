using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class TempPclmsCoursesService : CrudService<TempPclmsCourses>, ITempPclmsCoursesService {
        public TempPclmsCoursesService(ITempPclmsCoursesRepository repository) : base(repository) {}
    }
}