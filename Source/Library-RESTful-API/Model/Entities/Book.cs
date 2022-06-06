namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Book
{
    public Publication Publication { get; set; }

    public int PublicationId { get; set; }

    public string Isbn { get; set; }

    public Language Language { get; set; }

    public short LanguageId { get; set; }

    public string Title { get; set; }

    public Publisher Publisher { get; set; }

    public ushort PublisherId { get; set; }
    
    public DateTime PublicationDate { get; set; }

    public short Pages { get; set; }

    public string Description { get; set; }

    public string ImageUri { get; set; }

    public IEnumerable<BookLiterarySubgenre> BookLiterarySubgenres { get; set; }

    public IEnumerable<AuthorBook> AuthorBooks { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Book()
    {
    }

    /// <summary>
    /// Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Book(int publicationId, string isbn, Language language, string title, Publisher publisher, DateTime publicationDate, short pages, string description, string imageUri)
    {
        PublicationId = publicationId;
        Isbn = isbn;
        Language = language;
        Title = title;
        Publisher = publisher;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Book(string isbn, short languageId, string title, ushort publisherId, DateTime publicationDate, short pages, string description, string imageUri)
    {
        Isbn = isbn;
        LanguageId = languageId;
        Title = title;
        PublisherId = publisherId;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public Book(int publicationId, string isbn, short languageId, string title, ushort publisherId, DateTime publicationDate, short pages, string description, string imageUri)
    {
        PublicationId = publicationId;
        Isbn = isbn;
        LanguageId = languageId;
        Title = title;
        PublisherId = publisherId;
        PublicationDate = publicationDate;
        Pages = pages;
        Description = description;
        ImageUri = imageUri;
    }
}