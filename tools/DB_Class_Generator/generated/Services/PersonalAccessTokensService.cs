using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class PersonalAccessTokensService : CrudService<PersonalAccessTokens>, IPersonalAccessTokensService {
        public PersonalAccessTokensService(IPersonalAccessTokensRepository repository) : base(repository) {}
    }
}