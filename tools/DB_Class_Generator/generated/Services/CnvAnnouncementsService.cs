using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvAnnouncementsService : CrudService<CnvAnnouncements>, ICnvAnnouncementsService {
        public CnvAnnouncementsService(ICnvAnnouncementsRepository repository) : base(repository) {}
    }
}