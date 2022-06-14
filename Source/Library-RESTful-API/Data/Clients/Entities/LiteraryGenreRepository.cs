namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class LiteraryGenreRepository : Repository<LiteraryGenre, short>, ILiteraryGenreRepository<short>
{
    public LiteraryGenreRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<LiteraryGenre>>? GetAllLiteraryGenresAsync(short pageNumber, short pageSize, Expression<Func<LiteraryGenre, bool>>? filter = null, Func<IQueryable<LiteraryGenre>, IOrderedQueryable<LiteraryGenre>>? sort = null) => await GetAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<int> CountAllLiteraryGenresAsync(short pageNumber, short pageSize, Expression<Func<LiteraryGenre, bool>>? filter = null, Func<IQueryable<LiteraryGenre>, IOrderedQueryable<LiteraryGenre>>? sort = null) => await CountAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<LiteraryGenre>? GetLiteraryGenreFirstOrDefaultAsync(Expression<Func<LiteraryGenre, bool>> filter, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, changeTracking: changeTracking);

    public async Task<LiteraryGenre>? GetLiteraryGenreByIdAsync(short literaryGenreId, bool changeTracking = false) => await GetByIdAsync(literaryGenreId, changeTracking: changeTracking);

    public async Task AddLiteraryGenreAsync(LiteraryGenre literaryGenre) => await AddAsync(literaryGenre);

    public void UpdateLiteraryGenre(LiteraryGenre literaryGenre) => Update(literaryGenre);

    public void DeleteLiteraryGenre(LiteraryGenre literaryGenre) => Delete(literaryGenre);
}