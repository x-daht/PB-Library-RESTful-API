namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class Publication
{
    public int PublicationId { get; set; }

    public Book Book { get; set; }

    public Magazine Magazine { get; set; }

    public IEnumerable<PublicationFormat> PublicationFormats { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public Publication()
    {
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public Publication(int publicationId) => PublicationId = publicationId;
}