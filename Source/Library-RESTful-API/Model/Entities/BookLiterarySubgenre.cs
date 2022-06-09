namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class BookLiterarySubgenre
{
    public Book Book { get; set; }

    public int PublicationId { get; set; }

    public LiterarySubgenre LiterarySubgenre { get; set; }

    public short LiterarySubgenreId { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public BookLiterarySubgenre()
    {
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public BookLiterarySubgenre(int publicationId, short literarySubgenreId)
    {
        PublicationId = publicationId;
        LiterarySubgenreId = literarySubgenreId;
    }
}