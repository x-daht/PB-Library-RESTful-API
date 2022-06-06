namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class AuthorBookSeed : IEntityTypeConfiguration<AuthorBook>
{
    internal AuthorBookSeed()
    {
    }

    public void Configure(EntityTypeBuilder<AuthorBook> builder) =>
        _ = builder.HasData(
           new AuthorBook(1, 1),
           new AuthorBook(2, 2),
           new AuthorBook(3, 3),
           new AuthorBook(4, 4),
           new AuthorBook(5, 5)
           );
}