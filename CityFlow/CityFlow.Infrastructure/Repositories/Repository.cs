using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityFlow.Core.Entity;
using CityFlow.Infrastructure.Data;
using CityFlow.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CityFlow.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CityFlowContext _context;

        public Repository(CityFlowContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
             _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
             _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsNoTrackingAsync(bool isTracking = true)
        {
            if (isTracking)
                return await _context.Set<T>().ToListAsync();
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id, bool isTracking = true)
        {
            if (isTracking)
                return await _context.Set<T>().SingleOrDefaultAsync(x => x.Id == id);
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(T entity)
        {
             _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
