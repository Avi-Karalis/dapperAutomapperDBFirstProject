using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class DotnetPersonalaccesstokenService : CrudService<DotnetPersonalaccesstoken>, IDotnetPersonalaccesstokenService {
        public DotnetPersonalaccesstokenService(IDotnetPersonalaccesstokenRepository repository) : base(repository) {}
    }
}