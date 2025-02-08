using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseDiscussionTopicsEntriesService : CrudService<CnvCourseDiscussionTopicsEntries>, ICnvCourseDiscussionTopicsEntriesService {
        public CnvCourseDiscussionTopicsEntriesService(ICnvCourseDiscussionTopicsEntriesRepository repository) : base(repository) {}
    }
}