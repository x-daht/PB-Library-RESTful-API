namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IAuthorRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Author>>? GetAllAuthorsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null);

    Task<int> CountAllAuthorsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null);

    Task<Author>? GetAuthorFirstOrDefaultAsync(Expression<Func<Author, bool>> filter, string[]? properties = null, bool changeTracking = false);

    Task<Author>? GetAuthorByIdAsync(TNumericStructure authorId, string[]? properties = null, bool changeTracking = false);

    Task AddAuthorAsync(Author author);

    void UpdateAuthor(Author author);

    void DeleteAuthor(Author author);
}