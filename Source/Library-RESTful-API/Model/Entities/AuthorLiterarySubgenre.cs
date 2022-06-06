namespace Model.Entities;

#pragma warning  disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class AuthorLiterarySubgenre
{ 
    public Author Author { get; set; }

    public int AuthorId { get; set; }

    public LiterarySubgenre LiterarySubgenre { get; set; }

    public short LiterarySubgenreId { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public AuthorLiterarySubgenre()
    {
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public AuthorLiterarySubgenre(int authorId, short literarySubgenreId)
    {
        AuthorId = authorId;
        LiterarySubgenreId = literarySubgenreId;
    }
}