namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface ILiterarySubgenreRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<LiterarySubgenre>>? GetAllLiterarySubgenresAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<LiterarySubgenre, bool>>? filter = null, Func<IQueryable<LiterarySubgenre>, IOrderedQueryable<LiterarySubgenre>>? sort = null);

    Task<int> CountAllLiterarySubgenresAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<LiterarySubgenre, bool>>? filter = null, Func<IQueryable<LiterarySubgenre>, IOrderedQueryable<LiterarySubgenre>>? sort = null);

    Task<LiterarySubgenre>? GetLiterarySubgenreFirstOrDefaultAsync(Expression<Func<LiterarySubgenre, bool>> filter, string[]? properties = null, bool changeTracking = false);

    Task<LiterarySubgenre>? GetLiterarySubgenreByIdAsync(TNumericStructure literarySubgenreId, string[]? properties = null, bool changeTracking = false);

    Task AddLiterarySubgenreAsync(LiterarySubgenre literarySubgenre);

    void UpdateLiterarySubgenre(LiterarySubgenre literarySubgenre);

    void DeleteLiterarySubgenre(LiterarySubgenre literarySubgenre);
}