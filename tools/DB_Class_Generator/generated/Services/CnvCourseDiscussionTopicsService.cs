using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseDiscussionTopicsService : CrudService<CnvCourseDiscussionTopics>, ICnvCourseDiscussionTopicsService {
        public CnvCourseDiscussionTopicsService(ICnvCourseDiscussionTopicsRepository repository) : base(repository) {}
    }
}