using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Common
{
    public interface IRepository <TEntity, Tkey>
    {
        Task<List<TEntity>> GetAll(int page = 1);
        Task<TEntity> GetById(Tkey id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
    public interface IRepository<TEntity> : IRepository<TEntity, int> { } 
}
