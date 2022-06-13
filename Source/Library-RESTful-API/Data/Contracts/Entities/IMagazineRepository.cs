namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IMagazineRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Magazine>>? GetAllMagazinesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Magazine, bool>>? filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>>? sort = null);

    Task<int> CountAllMagazinesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Magazine, bool>>? filter = null, Func<IQueryable<Magazine>, IOrderedQueryable<Magazine>>? sort = null);

    Task<Magazine>? GetMagazineFirstOrDefaultAsync(Expression<Func<Magazine, bool>> filter, string[]? properties = null, bool changeTracking = false);

    Task<Magazine>? GetMagazineByIdAsync(TNumericStructure publicationId, string[]? properties = null, bool changeTracking = false);

    Task AddMagazineAsync(Magazine magazine);

    void UpdateMagazine(Magazine magazine);

    void DeleteMagazine(Magazine magazine);
}