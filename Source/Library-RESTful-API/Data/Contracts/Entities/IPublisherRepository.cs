namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface IPublisherRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Publisher>>? GetAllPublishersAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null);

    Task<int> CountAllPublishersAsync(TNumericStructure pageNumber, TNumericStructure pageSize, string[]? navigationProperties = null, Expression<Func<Publisher, bool>>? filter = null, Func<IQueryable<Publisher>, IOrderedQueryable<Publisher>>? sort = null);

    Task<Publisher>? GetPublisherFirstOrDefaultAsync(Expression<Func<Publisher, bool>> filter, string[]? navigationProperties = null, bool changeTracking = false);

    Task<Publisher>? GetPublisherByIdAsync(TNumericStructure publisherId, string[]? navigationProperties = null, bool changeTracking = false);

    Task AddPublisherAsync(Publisher publisher);

    void UpdatePublisher(Publisher publisher);

    void DeletePublisher(Publisher publisher);
}