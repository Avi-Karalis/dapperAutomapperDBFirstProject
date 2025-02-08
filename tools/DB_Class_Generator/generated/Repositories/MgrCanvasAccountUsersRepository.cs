using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasAccountUsersRepository : GenericRepository<MgrCanvasAccountUsers>, IMgrCanvasAccountUsersRepository {
        public MgrCanvasAccountUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}