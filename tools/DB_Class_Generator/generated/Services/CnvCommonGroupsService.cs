using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCommonGroupsService : CrudService<CnvCommonGroups>, ICnvCommonGroupsService {
        public CnvCommonGroupsService(ICnvCommonGroupsRepository repository) : base(repository) {}
    }
}