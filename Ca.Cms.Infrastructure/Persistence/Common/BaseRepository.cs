using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Infrastructure.Persistence.Common
{
    public class BaseRepository<TEntity, TKey> :IRepository<TEntity , TKey>
        where TEntity : class , IEntity<TKey>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _table;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _table.ToListAsync();
        }
        public async Task<TEntity> GetById(TKey id)
        {
            return await _table.FindAsync(id);
        }
        public async Task<int> Create(TEntity entity)
        {
            _table.Add(entity);
            return await _context.SaveChangesAsync();
        }
        public async Task Update(TEntity entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
            return;
        }
        public async Task Delete(TEntity entity)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
            return;
        }
    }
}
