using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasCoursesService : CrudService<MgrCanvasCourses>, IMgrCanvasCoursesService {
        public MgrCanvasCoursesService(IMgrCanvasCoursesRepository repository) : base(repository) {}
    }
}