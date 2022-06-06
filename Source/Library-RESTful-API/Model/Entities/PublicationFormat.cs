namespace Model.Entities;

#pragma warning disable

/// <summary>
/// Entity [Database Model]
/// </summary>
public sealed class PublicationFormat
{
    public Publication Publication { get; set; }

    public int PublicationId { get; set; }

    public Format Format { get; set; }

    public short FormatId { get; set; }

    /// <summary>
    /// Default empty constructor [IdentityDbContext]
    /// </summary>
    public PublicationFormat()
    {
    }

    /// <summary>
    /// Database seed constructor
    /// </summary>
    public PublicationFormat(int publicationId, short formatId)
    {
        PublicationId = publicationId;
        FormatId = formatId;
    }
}