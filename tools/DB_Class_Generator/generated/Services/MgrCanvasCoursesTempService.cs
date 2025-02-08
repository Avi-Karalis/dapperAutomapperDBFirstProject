using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasCoursesTempService : CrudService<MgrCanvasCoursesTemp>, IMgrCanvasCoursesTempService {
        public MgrCanvasCoursesTempService(IMgrCanvasCoursesTempRepository repository) : base(repository) {}
    }
}