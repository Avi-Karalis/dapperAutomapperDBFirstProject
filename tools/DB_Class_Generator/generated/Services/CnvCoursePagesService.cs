using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CnvCoursePagesService : CrudService<CnvCoursePages>, ICnvCoursePagesService {
        public CnvCoursePagesService(ICnvCoursePagesRepository repository) : base(repository) {}
    }
}