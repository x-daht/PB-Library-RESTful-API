namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IPublisherRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Publisher>>? GetAllPublishersAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null);

    Task<int> CountAllPublishersAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? properties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null);

    Task<Publisher>? GetPublisherFirstOrDefaultAsync(Expression<Func<Publisher, bool>> filter, string[]? properties = null, bool changeTracking = false);

    Task<Publisher>? GetPublisherByIdAsync(TNumericStructure publisherId, string[]? properties = null, bool changeTracking = false);

    Task AddPublisherAsync(Publisher publisher);

    void UpdatePublisher(Publisher publisher);

    void DeletePublisher(Publisher publisher);
}