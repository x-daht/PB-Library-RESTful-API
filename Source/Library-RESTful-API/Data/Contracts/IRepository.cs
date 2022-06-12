using System.Linq.Expressions;

namespace Data.Contracts;

public interface IRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>>? GetAllAsync(int pageNumber, int pageSize, string[]? properties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null);

    Task<int> CountAllAsync(int pageNumber, int pageSize, string[]? properties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null);

    Task<TEntity>? GetFirstOrDefaultAsync(string[]? properties = null, Expression<Func<TEntity, bool>>? filter = null, bool? changeTracking = null);

    Task<TEntity>? GetByIdAsync(int entityId, bool? changesTracking = null);

    Task AddAsync (TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}