using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class MgrCanvasSectionsRepository : GenericRepository<MgrCanvasSections>, IMgrCanvasSectionsRepository {
        public MgrCanvasSectionsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}