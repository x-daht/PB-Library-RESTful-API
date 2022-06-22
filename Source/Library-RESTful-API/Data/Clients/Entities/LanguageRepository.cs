namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class LanguageRepository : Repository<Language, short>, ILanguageRepository<short>
{
    public LanguageRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Language>>? GetAllLanguagesAsync(short pageNumber, short pageSize, Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? sort = null) => await GetAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<int> CountAllLanguagesAsync(short pageNumber, short pageSize, Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? sort = null) => await CountAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<Language>? GetLanguageFirstOrDefaultAsync(Expression<Func<Language, bool>> filter, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, changeTracking: changeTracking);

    public async Task<Language>? GetLanguageByIdAsync(short languageId, bool changeTracking = false) => await GetByIdAsync(languageId, changeTracking: changeTracking);

    public async Task AddLanguageAsync(Language language) => await AddAsync(language);

    public void UpdateLanguage(Language language) => Update(language);

    public void DeleteLanguage(Language language) => Delete(language);
}