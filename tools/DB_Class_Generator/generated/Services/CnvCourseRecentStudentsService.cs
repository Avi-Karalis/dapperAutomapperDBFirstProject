using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseRecentStudentsService : CrudService<CnvCourseRecentStudents>, ICnvCourseRecentStudentsService {
        public CnvCourseRecentStudentsService(ICnvCourseRecentStudentsRepository repository) : base(repository) {}
    }
}