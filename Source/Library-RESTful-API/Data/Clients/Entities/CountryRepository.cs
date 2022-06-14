namespace Data.Clients.Entities;

#pragma warning disable

/// <summary>
/// Granular client [Repository - Implementation]
/// </summary>
public sealed class CountryRepository : Repository<Country, short>, ICountryRepository<short>
{
    public CountryRepository(LibraryDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Country>>? GetAllCountriesAsync(short pageNumber, short pageSize, Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? sort = null) => await GetAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<int> CountAllCountriesAsync(short pageNumber, short pageSize, Expression<Func<Country, bool>>? filter = null, Func<IQueryable<Country>, IOrderedQueryable<Country>>? sort = null) => await CountAllAsync(pageNumber, pageSize, filter: filter, sort: sort);

    public async Task<Country>? GetCountryFirstOrDefaultAsync(Expression<Func<Country, bool>> filter, bool changeTracking = false) => await GetFirstOrDefaultAsync(filter, changeTracking: changeTracking);

    public async Task<Country>? GetCountryByIdAsync(short countryId, bool changeTracking = false) => await GetByIdAsync(countryId, changeTracking: changeTracking);

    public async Task AddCountryAsync(Country country) => await AddAsync(country);

    public void UpdateCountry(Country country) => Update(country);

    public void DeleteCountry(Country country) => Delete(country);
}