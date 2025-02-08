using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class DotnetPersonalaccesstokenRepository : GenericRepository<DotnetPersonalaccesstoken>, IDotnetPersonalaccesstokenRepository {
        public DotnetPersonalaccesstokenRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}