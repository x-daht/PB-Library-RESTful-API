namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class FormatSeed : IEntityTypeConfiguration<Format>
{
    internal FormatSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Format> builder) =>
        _ = builder.HasData(
            new Format(1, "Physical"),
            new Format(2, "Audio"),
            new Format(3, "Digital")
            );
}