using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashManager.DOMAIN.Contracts
{
    public interface IRepositoryBase<TEntity, TId> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity, bool isNew);
        IQueryable<TEntity> AsQueryable();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TId id);
        Task RemoveAsync(TEntity entity);
    }
}
