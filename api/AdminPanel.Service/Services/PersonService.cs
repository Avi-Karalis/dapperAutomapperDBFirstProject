using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;
namespace AdminPanel.Service.Services{
    public class PersonService : CrudService<Person>, IPersonService{
        public PersonService(IPersonRepository repository) : base(repository){}
    }
}