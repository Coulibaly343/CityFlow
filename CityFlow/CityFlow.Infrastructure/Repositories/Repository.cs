using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Repositories.Interfaces;

namespace CityFlow.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsNoTrackingAsync(bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, bool isTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
