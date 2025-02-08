using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class EventTestsService : CrudService<EventTests>, IEventTestsService {
        public EventTestsService(IEventTestsRepository repository) : base(repository) {}
    }
}