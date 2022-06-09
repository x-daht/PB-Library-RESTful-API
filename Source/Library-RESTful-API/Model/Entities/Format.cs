namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Format
{
    public short FormatId { get; set; }

    public string Name { get; set; }

    public IEnumerable<PublicationFormat> PublicationFormats { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Format()
    {
    }

    /// <summary>
    /// Database seed constructor | Data Transfer Object constructor [DTO - Output] 
    /// </summary>
    public Format(short formatId, string name)
    {
        FormatId = formatId;
        Name = name;
    }

    /// <summary>
    /// Data transfer object constructor [DTO - Input]
    /// </summary>
    public Format(string name) => Name = name;
}