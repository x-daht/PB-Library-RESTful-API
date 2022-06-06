namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class PublicationFormatSeed : IEntityTypeConfiguration<PublicationFormat>
{
    internal PublicationFormatSeed()
    {
    }

    public void Configure(EntityTypeBuilder<PublicationFormat> builder) =>
        _ = builder.HasData(
            new PublicationFormat(1, 1),
            new PublicationFormat(1, 2),
            new PublicationFormat(1, 3),
            new PublicationFormat(2, 1),
            new PublicationFormat(2, 2),
            new PublicationFormat(2, 3),
            new PublicationFormat(3, 1),
            new PublicationFormat(3, 2),
            new PublicationFormat(3, 3),
            new PublicationFormat(4, 1),
            new PublicationFormat(4, 2),
            new PublicationFormat(4, 3),
            new PublicationFormat(5, 1),
            new PublicationFormat(5, 2),
            new PublicationFormat(5, 3),
            new PublicationFormat(6, 1),
            new PublicationFormat(6, 3),
            new PublicationFormat(7, 1),
            new PublicationFormat(7, 3)
            );
}