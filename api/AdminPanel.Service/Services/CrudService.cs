using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
using AdminPanel.Service.Interfaces;
namespace AdminPanel.Service.Services{
    public class CrudService<T> : ICrudService<T> where T : IEntity {
        protected readonly IGenericRepository<T> _repository;
        public CrudService(IGenericRepository<T> repository) => _repository = repository;
        public virtual async Task<IEnumerable<T>> ListAsync(QueryParameters? queryParams) => await _repository.ListAsync(queryParams);
        public virtual async Task<T> GetAsync(ulong id) => await _repository.GetAsync(id);
        public virtual async Task<T> CreateAsync(T entity) => await _repository.CreateAsync(entity);
        public virtual async Task<T> UpdateAsync(T entity) => await _repository.UpdateAsync(entity);
        public virtual async Task DeleteAsync(T entity) => await _repository.DeleteAsync(entity);
    }
}