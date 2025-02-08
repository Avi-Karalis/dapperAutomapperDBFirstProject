using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class MigrationsService : CrudService<Migrations>, IMigrationsService {
        public MigrationsService(IMigrationsRepository repository) : base(repository) {}
    }
}