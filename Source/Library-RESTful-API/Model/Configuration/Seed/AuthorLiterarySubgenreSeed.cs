namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class AuthorLiterarySubgenreSeed : IEntityTypeConfiguration<AuthorLiterarySubgenre>
{
    internal AuthorLiterarySubgenreSeed()
    {
    }

    public void Configure(EntityTypeBuilder<AuthorLiterarySubgenre> builder) =>
        _ = builder.HasData(
            new AuthorLiterarySubgenre(1, 1),
            new AuthorLiterarySubgenre(1, 2),
            new AuthorLiterarySubgenre(2, 1),
            new AuthorLiterarySubgenre(2, 17),
            new AuthorLiterarySubgenre(2, 19),
            new AuthorLiterarySubgenre(3, 7),
            new AuthorLiterarySubgenre(3, 8),
            new AuthorLiterarySubgenre(3, 9),
            new AuthorLiterarySubgenre(3, 17),
            new AuthorLiterarySubgenre(3, 19),
            new AuthorLiterarySubgenre(4, 1),
            new AuthorLiterarySubgenre(4, 2),
            new AuthorLiterarySubgenre(4, 26),
            new AuthorLiterarySubgenre(4, 36),
            new AuthorLiterarySubgenre(5, 8),
            new AuthorLiterarySubgenre(5, 9)
            );
}