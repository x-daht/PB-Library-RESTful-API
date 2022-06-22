namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IAuthorRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Author>>? GetAllAuthorsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null);

    Task<int> CountAllAuthorsAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null);

    Task<Author>? GetAuthorFirstOrDefaultAsync(Expression<Func<Author, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false);

    Task<Author>? GetAuthorByIdAsync(TNumericStructure authorId, string[]? navigationProperties = null, bool changeTracking = false);

    Task AddAuthorAsync(Author author);

    void UpdateAuthor(Author author);

    void DeleteAuthor(Author author);
}