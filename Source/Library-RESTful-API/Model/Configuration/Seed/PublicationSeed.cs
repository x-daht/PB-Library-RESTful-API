namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class PublicationSeed : IEntityTypeConfiguration<Publication>
{
    internal PublicationSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Publication> builder) =>
        _ = builder.HasData(
            new Publication(1),
            new Publication(2),
            new Publication(3),
            new Publication(4),
            new Publication(5),
            new Publication(6),
            new Publication(7)
            );
}