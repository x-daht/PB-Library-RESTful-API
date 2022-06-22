namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface ILiteraryGenreRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<LiteraryGenre>>? GetAllLiteraryGenresAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<LiteraryGenre, bool>>? filter = null, Func<IQueryable<LiteraryGenre>, IOrderedQueryable<LiteraryGenre>>? sort = null);

    Task<int> CountAllLiteraryGenresAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<LiteraryGenre, bool>>? filter = null, Func<IQueryable<LiteraryGenre>, IOrderedQueryable<LiteraryGenre>>? sort = null);

    Task<LiteraryGenre>? GetLiteraryGenreFirstOrDefaultAsync(Expression<Func<LiteraryGenre, bool>> filter, bool changeTracking = false);

    Task<LiteraryGenre>? GetLiteraryGenreByIdAsync(TNumericStructure literaryGenreId, bool changeTracking = false);

    Task AddLiteraryGenreAsync(LiteraryGenre literaryGenre);

    void UpdateLiteraryGenre(LiteraryGenre literaryGenre);

    void DeleteLiteraryGenre(LiteraryGenre literaryGenre);
}