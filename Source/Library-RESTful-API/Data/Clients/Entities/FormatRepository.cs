namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class FormatRepository : Repository<Format, short>, IFormatRepository<short>
{
    public FormatRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Format>>? GetAllFormatsAsync(short pageNumber, short pageSize, Expression<Func<Format, bool>>? filter = null, Func<IQueryable<Format>, IOrderedQueryable<Format>>? sort = null) => await GetAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<int> CountAllFormatsAsync(short pageNumber, short pageSize, Expression<Func<Format, bool>>? filter = null, Func<IQueryable<Format>, IOrderedQueryable<Format>>? sort = null) => await CountAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<Format> GetFormatFirstOrDefaultAsync(Expression<Func<Format, bool>> filter, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, changeTracking: changeTracking);

    public async Task<Format> GetFormatByIdAsync(short formatId, bool changeTracking = false) => await GetByIdAsync(formatId, changeTracking: changeTracking);
}