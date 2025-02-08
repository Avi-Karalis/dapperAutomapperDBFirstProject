using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasDiscussionEntriesService : CrudService<MgrCanvasDiscussionEntries>, IMgrCanvasDiscussionEntriesService {
        public MgrCanvasDiscussionEntriesService(IMgrCanvasDiscussionEntriesRepository repository) : base(repository) {}
    }
}