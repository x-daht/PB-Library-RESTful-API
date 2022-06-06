namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class LiterarySubgenre
{
    public short LiterarySubgenreId { get; set; }

    public string Name { get; set; }

    public LiteraryGenre LiteraryGenre { get; set; }

    public short LiteraryGenreId { get; set; }

    public string Description { get; set; }

    public IEnumerable<AuthorLiterarySubgenre> AuthorLiterarySubgenres { get; set; }

    public IEnumerable<BookLiterarySubgenre> BookLiterarySubgenres { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public LiterarySubgenre()
    {
    }

    /// <summary>
    /// Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public LiterarySubgenre(short literarySubgenreId, string name, LiteraryGenre literaryGenre, string description)
    {
        LiterarySubgenreId = literarySubgenreId;
        Name = name;
        LiteraryGenre = literaryGenre;
        Description = description;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public LiterarySubgenre(string name, short literaryGenreId, string description)
    {
        Name = name;
        LiteraryGenreId = literaryGenreId;
        Description = description;
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public LiterarySubgenre(short literarySubgenreId, string name, short literaryGenreId, string description)
    {
        LiterarySubgenreId = literarySubgenreId;
        Name = name;
        LiteraryGenreId = literaryGenreId;
        Description = description;
    }
}