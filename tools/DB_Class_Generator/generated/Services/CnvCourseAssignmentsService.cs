using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseAssignmentsService : CrudService<CnvCourseAssignments>, ICnvCourseAssignmentsService {
        public CnvCourseAssignmentsService(ICnvCourseAssignmentsRepository repository) : base(repository) {}
    }
}