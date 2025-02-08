using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasUsersRepository : GenericRepository<MgrCanvasUsers>, IMgrCanvasUsersRepository {
        public MgrCanvasUsersRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}