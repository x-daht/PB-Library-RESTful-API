namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class LiteraryGenre
{
    public short LiteraryGenreId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public IEnumerable<LiterarySubgenre> LiterarySubgenres { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public LiteraryGenre()
    {
    }

    /// <summary>
    /// Database seed constructor | Data Transfer Object constructor [DTO - Output] 
    /// </summary>
    public LiteraryGenre(short literaryGenreId, string name, string description)
    {
        LiteraryGenreId = literaryGenreId;
        Name = name;
        Description = description;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public LiteraryGenre(string name, string description)
    {
        Name = name;
        Description = description;
    }
}