using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class CourseLikesService : CrudService<CourseLikes>, ICourseLikesService {
        public CourseLikesService(ICourseLikesRepository repository) : base(repository) {}
    }
}