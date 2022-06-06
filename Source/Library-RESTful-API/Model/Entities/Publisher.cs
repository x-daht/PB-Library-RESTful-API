namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Publisher
{
    public ushort PublisherId { get; set; }

    public string Name { get; set; }

    public Country Country { get; set; }

    public short CountryId { get; set; }

    public bool Status { get; set; }

    public IEnumerable<Book> Books { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Publisher()
    {
    }

    /// <summary>
    /// Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Publisher(ushort publisherId, string name, Country country, bool status)
    {
        PublisherId = publisherId;
        Name = name;
        Country = country;
        Status = status;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Publisher(string name, short countryId, bool status)
    {
        Name = name;
        CountryId = countryId;
        Status = status;
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public Publisher(ushort publisherId, string name, short countryId, bool status)
    {
        PublisherId = publisherId;
        Name = name;
        CountryId = countryId;
        Status = status;
    }
}