namespace Data.Clients;

#pragma warning disable

/// <summary>
/// General client [Repository - Implementation]
/// </summary>
public abstract class Repository<TEntity, TNumericStructure> : IRepository<TEntity, TNumericStructure> where TEntity : class where TNumericStructure : struct
{
    private protected readonly LibraryDbContext _context;

    protected Repository(LibraryDbContext context) => _context = context;

    private async Task<IQueryable<TEntity>> GetGeneralQueryAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null)
    {
        try
        {
            await _context.Database.OpenConnectionAsync();
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (navigationProperties is not null) foreach (string navigationProperty in navigationProperties) query = query.Include(navigationProperty.Trim());
            if (filter is not null) query = query.Where(filter);
            if (sort is not null) query = sort(query);
            query = await Paginator<TEntity>.GeneratePartition(query, Convert.ToInt32(pageNumber), Convert.ToInt32(pageSize));
            return await Task.FromResult(query.AsNoTracking());
        }
        finally
        {
            await _context.Database.CloseConnectionAsync();
        }
    }

    public async Task<IEnumerable<TEntity>>? GetAllAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null) => await GetGeneralQueryAsync(pageNumber, pageSize, navigationProperties, filter, sort).Result.ToListAsync();

    public async Task<int> CountAllAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? sort = null) => await GetGeneralQueryAsync(pageNumber, pageSize, navigationProperties, filter, sort).Result.CountAsync();

    public async Task<TEntity>? GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false)
    {
        try
        {
            await _context.Database.OpenConnectionAsync();
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (navigationProperties is not null) foreach (string navigationProperty in navigationProperties) query = query.Include(navigationProperty.Trim());
            if (filter is not null) query = query.Where(filter);
            if (changeTracking is false) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync();
        }
        finally
        {
            await _context.Database.CloseConnectionAsync();
        }
    }

    public async Task<TEntity>? GetByIdAsync(TNumericStructure entityId, string[]? navigationProperties = null, bool changeTracking = false)
    {
        try
        {
            await _context.Database.OpenConnectionAsync();
            DbSet<TEntity> query = _context.Set<TEntity>();
            if (navigationProperties is not null) foreach (string navigationProperty in navigationProperties) query = (DbSet<TEntity>)query.Include(navigationProperty.Trim());
            if (changeTracking is false) query = (DbSet<TEntity>)query.AsNoTracking();
            return await query.FindAsync(entityId);
        }
        finally
        {
            await _context.Database.CloseConnectionAsync();
        }
    }

    public async Task AddAsync(TEntity entity)
    {
        try
        {
            await _context.Database.OpenConnectionAsync();
            _ = await _context.Set<TEntity>().AddAsync(entity);
            _ = await _context.SaveChangesAsync();

        }
        finally
        {
            await _context.Database.CloseConnectionAsync();
        }
    }

    public void Update(TEntity entity)
    {
        try
        {
            _context.Database.OpenConnection();
            _ = _context.Set<TEntity>().Update(entity);
            _ = _context.SaveChanges();

        }
        finally
        {
            _context.Database.CloseConnection();
        }
    }

    public void Delete(TEntity entity)
    {
        try
        {
            _context.Database.OpenConnection();
            _ = _context.Set<TEntity>().Remove(entity);
            _ = _context.SaveChanges();
        }
        finally
        {
            _context.Database.CloseConnection();
        }
    }
}