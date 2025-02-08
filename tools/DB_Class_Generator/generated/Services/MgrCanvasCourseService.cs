using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasCourseService : CrudService<MgrCanvasCourse>, IMgrCanvasCourseService {
        public MgrCanvasCourseService(IMgrCanvasCourseRepository repository) : base(repository) {}
    }
}