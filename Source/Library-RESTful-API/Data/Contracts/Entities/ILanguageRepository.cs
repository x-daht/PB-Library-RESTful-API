namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface ILanguageRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Language>>? GetAllLanguagesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? sort = null);

    Task<int> CountAllLanguagesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Language, bool>>? filter = null, Func<IQueryable<Language>, IOrderedQueryable<Language>>? sort = null);

    Task<Language>? GetLanguageFirstOrDefaultAsync(Expression<Func<Language, bool>> filter, bool changeTracking = false);

    Task<Language>? GetLanguageByIdAsync(TNumericStructure languageId, bool changeTracking = false);

    Task AddLanguageAsync(Language language);

    void UpdateLanguage(Language language);

    void DeleteLanguage(Language language);
}