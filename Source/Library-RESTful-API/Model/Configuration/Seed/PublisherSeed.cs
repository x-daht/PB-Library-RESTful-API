namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class PublisherSeed : IEntityTypeConfiguration<Publisher>
{
    internal PublisherSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Publisher> builder) =>
        _ = builder.HasData(
            new Publisher(1, "Penguin Books", 185, true),
            new Publisher(2, "Simon & Schuster", 186, true),
            new Publisher(3, "Saneca", 113, true),
            new Publisher(4, "Editorial Sudamericana", 7, true),
            new Publisher(5, "Editorial Losada", 7, true)
            );
}