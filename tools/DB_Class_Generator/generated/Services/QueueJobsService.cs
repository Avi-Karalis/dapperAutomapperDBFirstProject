using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class QueueJobsService : CrudService<QueueJobs>, IQueueJobsService {
        public QueueJobsService(IQueueJobsRepository repository) : base(repository) {}
    }
}