using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MgrCanvasDiscussionTopicsService : CrudService<MgrCanvasDiscussionTopics>, IMgrCanvasDiscussionTopicsService {
        public MgrCanvasDiscussionTopicsService(IMgrCanvasDiscussionTopicsRepository repository) : base(repository) {}
    }
}