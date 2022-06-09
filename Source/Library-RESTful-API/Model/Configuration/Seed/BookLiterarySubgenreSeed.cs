namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class BookLiterarySubgenreSeed : IEntityTypeConfiguration<BookLiterarySubgenre>
{
    internal BookLiterarySubgenreSeed()
    {
    }

    public void Configure(EntityTypeBuilder<BookLiterarySubgenre> builder) =>
        _ = builder.HasData(
            new BookLiterarySubgenre(1, 1),
            new BookLiterarySubgenre(2, 2),
            new BookLiterarySubgenre(3, 7),
            new BookLiterarySubgenre(3, 8),
            new BookLiterarySubgenre(3, 9),
            new BookLiterarySubgenre(4, 1),
            new BookLiterarySubgenre(5, 8),
            new BookLiterarySubgenre(5, 9)
            );
}