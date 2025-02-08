using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasSectionsService : CrudService<MgrCanvasSections>, IMgrCanvasSectionsService {
        public MgrCanvasSectionsService(IMgrCanvasSectionsRepository repository) : base(repository) {}
    }
}