namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class AuthorBook
{
    public Author Author { get; set; }

    public int AuthorId { get; set; }

    public Book Book { get; set; }

    public int PublicationId { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public AuthorBook()
    {
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public AuthorBook(int authorId, int publicationId)
    {
        AuthorId = authorId;
        PublicationId = publicationId;
    }
}