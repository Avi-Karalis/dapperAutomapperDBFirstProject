using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasCoursesBckService : CrudService<MgrCanvasCoursesBck>, IMgrCanvasCoursesBckService {
        public MgrCanvasCoursesBckService(IMgrCanvasCoursesBckRepository repository) : base(repository) {}
    }
}