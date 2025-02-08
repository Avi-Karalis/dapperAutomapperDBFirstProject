using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasStateService : CrudService<MgrCanvasState>, IMgrCanvasStateService {
        public MgrCanvasStateService(IMgrCanvasStateRepository repository) : base(repository) {}
    }
}