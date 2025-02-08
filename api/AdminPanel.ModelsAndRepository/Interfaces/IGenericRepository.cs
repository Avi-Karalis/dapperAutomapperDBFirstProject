using AdminPanel.ModelsAndRepository.Models;
namespace AdminPanel.ModelsAndRepository.Interfaces {
    public interface IGenericRepository<T> where T : IEntity {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> ListAsync(QueryParameters? queryParams);
        Task<T?> GetAsync(ulong id);
    }
    
}