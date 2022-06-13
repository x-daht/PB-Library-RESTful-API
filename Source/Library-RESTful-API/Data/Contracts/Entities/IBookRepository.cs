namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IBookRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Book>>? GetAllBooksAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Book, bool>>? filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>>? sort = null);

    Task<int> CountAllBooksAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Book, bool>>? filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>>? sort = null);

    Task<Book>? GetBookFirstOrDefaultAsync(Expression<Func<Book, bool>> filter, string[]? properties = null, bool changeTracking = false);

    Task<Book>? GetBookByIdAsync(TNumericStructure publicationId, string[]? properties = null, bool changeTracking = false);

    Task AddBookAsync(Book book);

    void UpdateBook(Book book);

    void DeleteBook(Book book);
}