namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class LiterarySubgenreRepository : Repository<LiterarySubgenre, short>, ILiterarySubgenreRepository<short>
{
    public LiterarySubgenreRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<LiterarySubgenre>>? GetAllLiterarySubgenresAsync(short pageNumber, short pageSize, string[]? navigationProperties = null, Expression<Func<LiterarySubgenre, bool>>? filter = null, Func<IQueryable<LiterarySubgenre>, IOrderedQueryable<LiterarySubgenre>>? sort = null) => await GetAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<int> CountAllLiterarySubgenresAsync(short pageNumber, short pageSize, string[]? navigationProperties = null, Expression<Func<LiterarySubgenre, bool>>? filter = null, Func<IQueryable<LiterarySubgenre>, IOrderedQueryable<LiterarySubgenre>>? sort = null) => await CountAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<LiterarySubgenre>? GetLiterarySubgenreFirstOrDefaultAsync(Expression<Func<LiterarySubgenre, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, navigationProperties, changeTracking);

    public async Task<LiterarySubgenre>? GetLiterarySubgenreByIdAsync(short literarySubgenreId, string[]? navigationProperties = null, bool changeTracking = false) => await GetByIdAsync(literarySubgenreId, navigationProperties, changeTracking);

    public async Task AddLiterarySubgenreAsync(LiterarySubgenre literarySubgenre) => await AddAsync(literarySubgenre);

    public void UpdateLiterarySubgenre(LiterarySubgenre literarySubgenre) => Update(literarySubgenre);

    public void DeleteLiterarySubgenre(LiterarySubgenre literarySubgenre) => Delete(literarySubgenre);
}