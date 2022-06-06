namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Magazine
{
    public Publication Publication { get; set; }

    public int PublicationId { get; set; }

    public string Issn { get; set; }

    public Language Language { get; set; }

    public short LanguageId { get; set; }

    public string Name { get; set; }

    public DateTime PublicationDate { get; set; }

    public short Pages { get; set; }

    public string Description { get; set; }

    public string ImageUri { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Magazine()
    {
    }

    /// <summary>
    /// Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Magazine(int publicationId, string issn, Language language, string name, DateTime publicationDate, short pages, string description, string imageUri)
    {
        PublicationId = publicationId;
        Issn = issn;
        Language = language;
        Name = name;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Magazine(string issn, short languageId, string name, DateTime publicationDate, short pages, string description, string imageUri)
    {
        Issn = issn;
        LanguageId = languageId;
        Name = name;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public Magazine(int publicationId, string issn, short languageId, string name, DateTime publicationDate, short pages, string description, string imageUri)
    {
        PublicationId = publicationId;
        Issn = issn;
        LanguageId = languageId;
        Name = name;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }
}