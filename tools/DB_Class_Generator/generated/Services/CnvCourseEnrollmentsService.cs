using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCourseEnrollmentsService : CrudService<CnvCourseEnrollments>, ICnvCourseEnrollmentsService {
        public CnvCourseEnrollmentsService(ICnvCourseEnrollmentsRepository repository) : base(repository) {}
    }
}