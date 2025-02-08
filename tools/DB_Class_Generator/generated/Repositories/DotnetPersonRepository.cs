using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class DotnetPersonRepository : GenericRepository<DotnetPerson>, IDotnetPersonRepository {
        public DotnetPersonRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}