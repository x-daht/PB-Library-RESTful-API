namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Author
{
    public int AuthorId { get; set; }

    public string Names { get; set; }
 
    public string Surnames { get; set; }

    public Country Country { get; set; }

    public short CountryId { get; set; }

    public string Description { get; set; }

    public string ImageUri { get; set; }

    public IEnumerable<AuthorLiterarySubgenre> AuthorLiterarySubgenres { get; set; }

    public IEnumerable<AuthorBook> AuthorBooks { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Author()
    {
    }

    /// <summary>
    /// Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Author(int authorId, string names, string surnames, Country country, string description, string imageUri)
    {
        AuthorId = authorId;
        Names = names;
        Surnames = surnames;
        Country = country;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Author(string names, string surnames, short countryId, string description, string imageUri)
    {
        Names = names;
        Surnames = surnames;
        CountryId = countryId;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public Author(int authorId, string names, string surnames, short countryId, string description, string imageUri)
    {
        AuthorId = authorId;
        Names = names;
        Surnames = surnames;
        CountryId = countryId;
        Description = description;
        ImageUri = imageUri;
    }
}