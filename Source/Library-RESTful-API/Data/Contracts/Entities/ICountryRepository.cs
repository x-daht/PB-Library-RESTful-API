namespace Data.Contracts.Entities;

/// <summary>
/// Granular contract [Repository - Declaration]
/// </summary>
public interface ICountryRepository<TNumericStructure> where TNumericStructure : struct
{
    Task<IEnumerable<Country>>? GetAllCountriesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? sort = null);

    Task<int> CountAllCountriesAsync(TNumericStructure pageNumber, TNumericStructure pageSize, Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? sort = null);

    Task<Country>? GetCountryFirstOrDefaultAsync(Expression<Func<Country, bool>> filter, bool changeTracking = false);

    Task<Country>? GetCountryByIdAsync(TNumericStructure countryId, bool changeTracking = false);

    Task AddCountryAsync(Country country);

    void UpdateCountry(Country country);

    void DeleteCountry(Country country);
} 