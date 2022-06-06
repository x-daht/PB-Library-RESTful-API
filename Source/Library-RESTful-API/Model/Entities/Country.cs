namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Country
{
    public short CountryId { get; set; }

    public string Name { get; set; }

    public string AlphaCodeTwo { get; set; }

    public string AlphaCodeThree { get; set; }

    public short NumericCode { get; set; }

    public string ImageUri { get; set; }

    public IEnumerable<Author> Authors { get; set; }

    public IEnumerable<Publisher> Publishers { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Country()
    {
    }

    /// <summary>
    /// Database seed constructor | Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Country(short countryId, string name, string alphaCodeTwo, string alphaCodeThree, short numericCode, string imageUri)
    {
        CountryId = countryId;
        Name = name;
        AlphaCodeTwo = alphaCodeTwo;
        AlphaCodeThree = alphaCodeThree;
        NumericCode = numericCode;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Country(string name, string alphaCodeTwo, string alphaCodeThree, short numericCode, string imageUri)
    {
        Name = name;
        AlphaCodeTwo = alphaCodeTwo;
        AlphaCodeThree = alphaCodeThree;
        NumericCode = numericCode;
        ImageUri = imageUri;
    }
}