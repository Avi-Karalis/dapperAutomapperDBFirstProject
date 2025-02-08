using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvSubmissionsService : CrudService<CnvSubmissions>, ICnvSubmissionsService {
        public CnvSubmissionsService(ICnvSubmissionsRepository repository) : base(repository) {}
    }
}