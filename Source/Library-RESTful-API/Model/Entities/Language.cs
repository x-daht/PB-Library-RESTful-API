namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Language
{
    public short LanguageId { get; set; }

    public string Name { get; set; }

    public IEnumerable<Book> Books { get; set; }

    public IEnumerable<Magazine> Magazines { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Language()
    {
    }

    /// <summary>
    /// Database seed constructor | Data Transfer Object constructor [DTO - Output]
    /// </summary>
    public Language(short languageId, string name)
    {
        LanguageId = languageId;
        Name = name;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Language(string name) => Name = name;
}