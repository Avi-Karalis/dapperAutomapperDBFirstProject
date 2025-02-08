using System.Data;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;

namespace AdminPanel.ModelsAndRepository.Repositories {
    public class LmsAssignmentsRepository : GenericRepository<LmsAssignments>, ILmsAssignmentsRepository {
        public LmsAssignmentsRepository(IDbConnection dbConnection) : base(dbConnection) {}
    }
}