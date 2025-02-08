using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseAttachmentsService : CrudService<LmsCourseAttachments>, ILmsCourseAttachmentsService {
        public LmsCourseAttachmentsService(ILmsCourseAttachmentsRepository repository) : base(repository) {}
    }
}