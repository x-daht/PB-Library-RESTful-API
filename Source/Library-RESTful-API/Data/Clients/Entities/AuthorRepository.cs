namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class AuthorRepository : Repository<Author, int>, IAuthorRepository<int>
{
    public AuthorRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Author>>? GetAllAuthorsAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null) => await GetAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<int> CountAllAuthorsAsync(int pageNumber, int pageSize, string[]? navigationProperties = null, Expression<Func<Author, bool>>? filter = null, Func<IQueryable<Author>, IOrderedQueryable<Author>>? sort = null) => await CountAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<Author>? GetAuthorFirstOrDefaultAsync(Expression<Func<Author, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, navigationProperties, changeTracking);

    public async Task<Author>? GetAuthorByIdAsync(int authorId, string[]? navigationProperties = null, bool changeTracking = false) => await GetByIdAsync(authorId, navigationProperties, changeTracking);

    public async Task AddAuthorAsync(Author author) => await AddAsync(author);

    public void UpdateAuthor(Author author) => Update(author);

    public void DeleteAuthor(Author author) => Delete(author);
}