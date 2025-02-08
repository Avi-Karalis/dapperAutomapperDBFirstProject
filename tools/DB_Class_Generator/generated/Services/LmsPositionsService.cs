using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsPositionsService : CrudService<LmsPositions>, ILmsPositionsService {
        public LmsPositionsService(ILmsPositionsRepository repository) : base(repository) {}
    }
}