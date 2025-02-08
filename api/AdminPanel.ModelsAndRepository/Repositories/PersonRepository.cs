using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
using System.Data;
namespace AdminPanel.ModelsAndRepository.Repositories {
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(IDbConnection connection) :
            base(connection)
        {
        }
    }
}