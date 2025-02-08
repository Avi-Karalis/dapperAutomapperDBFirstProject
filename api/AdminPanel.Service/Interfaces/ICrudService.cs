using AdminPanel.ModelsAndRepository.Interfaces;
using AdminPanel.ModelsAndRepository.Models;
namespace AdminPanel.Service.Interfaces
{
    public interface ICrudService<T> where T : IEntity
    {
        Task<IEnumerable<T>> ListAsync(QueryParameters? queryParams);
        Task<T> GetAsync(ulong id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}