namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class BookRepository : Repository<Book, int>, IBookRepository<int>
{
    public BookRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Book>>? GetAllBooksAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Book, bool>>? filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>>? sort = null) => await GetAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<int> CountAllBooksAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Book, bool>>? filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>>? sort = null) => await CountAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<Book>? GetBookFirstOrDefaultAsync(Expression<Func<Book, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, navigationProperties, changeTracking);

    public async Task<Book>? GetBookByIdAsync(int publicationId, string[]? navigationProperties = null, bool changeTracking = false) => await GetByIdAsync(publicationId, navigationProperties, changeTracking);

    public async Task AddBookAsync(Book book) => await AddAsync(book);

    public void UpdateBook(Book book) => Update(book);

    public void DeleteBook(Book book) => Delete(book);
}