namespace Pagination;

/// <summary>
/// Data partitionator
/// </summary>
public static class Paginator<TEntity> where TEntity : class
{
    public static async Task<IQueryable<TEntity>> GeneratePartition(IQueryable<TEntity> query, int pageNumber, int pageSize) => await Task.FromResult(query.Skip(pageSize * (pageNumber - 1)).Take(pageSize));
}