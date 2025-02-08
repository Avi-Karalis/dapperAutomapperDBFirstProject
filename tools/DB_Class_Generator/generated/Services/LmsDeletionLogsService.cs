using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsDeletionLogsService : CrudService<LmsDeletionLogs>, ILmsDeletionLogsService {
        public LmsDeletionLogsService(ILmsDeletionLogsRepository repository) : base(repository) {}
    }
}