using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityFlow.Infrastructure.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id, bool isTracking=true);
        Task<IEnumerable<T>> GetAllAsNoTrackingAsync(bool isTracking = true);
        Task AddAsync(T entity);
        Task Update(T entity);
        Task DeleteByIdAsync(int id);
        Task Delete(T entity);
    }
}
