using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasStateRepository : GenericRepository<MgrCanvasState>, IMgrCanvasStateRepository {
        public MgrCanvasStateRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}