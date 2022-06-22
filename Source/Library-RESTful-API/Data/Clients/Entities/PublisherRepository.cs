namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class PublisherRepository : Repository<Publisher, ushort>, IPublisherRepository<ushort>
{
    public PublisherRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Publisher>>? GetAllPublishersAsync(ushort pageNumber, ushort pageSize, string[]? navigationProperties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null) => await GetAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<int> CountAllPublishersAsync(ushort pageNumber, ushort pageSize, string[]? navigationProperties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null) => await CountAllAsync(pageNumber, pageSize, navigationProperties, filter, sort);

    public async Task<Publisher>? GetPublisherFirstOrDefaultAsync(Expression<Func<Publisher, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, navigationProperties, changeTracking);

    public async Task<Publisher>? GetPublisherByIdAsync(ushort publisherId, string[]? navigationProperties = null, bool changeTracking = false) => await GetByIdAsync(publisherId, navigationProperties, changeTracking);

    public async Task AddPublisherAsync(Publisher publisher) => await AddAsync(publisher);

    public void UpdatePublisher(Publisher publisher) => Update(publisher);

    public void DeletePublisher(Publisher publisher) => Delete(publisher);
}