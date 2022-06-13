namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IFormatRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Format>>? GetAllFormatsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Format, bool>>? filter = null, Func<IQueryable<Format>, IOrderedQueryable<Format>>? sort = null);

    Task<int> CountAllFormatsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Format, bool>>? filter = null, Func<IQueryable<Format>, IOrderedQueryable<Format>>? sort = null);

    Task<Format> GetFormatFirstOrDefaultAsync(Expression<Func<Format, bool>> filter, bool changeTracking = false);

    Task<Format> GetFormatByIdAsync(TNumericStructure formatId, bool changeTracking = false);
}