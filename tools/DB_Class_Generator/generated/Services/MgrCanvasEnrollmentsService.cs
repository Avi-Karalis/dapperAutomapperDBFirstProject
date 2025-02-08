using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasEnrollmentsService : CrudService<MgrCanvasEnrollments>, IMgrCanvasEnrollmentsService {
        public MgrCanvasEnrollmentsService(IMgrCanvasEnrollmentsRepository repository) : base(repository) {}
    }
}