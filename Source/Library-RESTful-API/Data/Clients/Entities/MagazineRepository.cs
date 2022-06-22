namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class MagazineRepository : Repository<Magazine, int>, IMagazineRepository<int>
{
    public MagazineRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Magazine>>? GetAllMagazinesAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Magazine, bool>>? filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>>? sort = null) => await GetAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<int> CountAllMagazinesAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Magazine, bool>>? filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>>? sort = null) => await CountAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<Magazine>? GetMagazineFirstOrDefaultAsync(Expression<Func<Magazine, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, navigationProperties, changeTracking);

    public async Task<Magazine>? GetMagazineByIdAsync(int publicationId, string[]? navigationProperties = null, bool changeTracking = false) => await GetByIdAsync(publicationId, navigationProperties, changeTracking);

    public async Task AddMagazineAsync(Magazine magazine) => await AddAsync(magazine);

    public void UpdateMagazine(Magazine magazine) => Update(magazine);

    public void DeleteMagazine(Magazine magazine) => Delete(magazine);
}