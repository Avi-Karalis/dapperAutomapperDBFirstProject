using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.Service.Interfaces;

namespace AdminPanel.Service.Services {
    public class LmsCourseTaxonomiesService : CrudService<LmsCourseTaxonomies>, ILmsCourseTaxonomiesService {
        public LmsCourseTaxonomiesService(ILmsCourseTaxonomiesRepository repository) : base(repository) {}
    }
}