namespace Data.Contracts;

/// <summary>
/// General contract [Repository - Declaration]
/// </summary>
public interface IRepository<TEntity, TNumericStructure> where TEntity : class where TNumericStructure : struct
{
    Task<IEnumerable<TEntity>>? GetAllAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null);
    
    Task<int> CountAllAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null);

    Task<TEntity>? GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false);

    Task<TEntity>? GetByIdAsync(TNumericStructure entityId, string[]? navigationProperties = null, bool changeTracking = false);

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}