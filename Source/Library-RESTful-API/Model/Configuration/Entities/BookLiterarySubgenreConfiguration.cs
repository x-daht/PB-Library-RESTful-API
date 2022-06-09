namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class BookLiterarySubgenreConfiguration : BaseSchema, IEntityTypeConfiguration<BookLiterarySubgenre>
{
    internal BookLiterarySubgenreConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<BookLiterarySubgenre> builder)
    {
        _ = builder.ToTable(nameof(BookLiterarySubgenre), _schema).HasKey(p => new { p.PublicationId, p.LiterarySubgenreId });
        _ = builder.HasOne(p => p.Book).WithMany(p => p.BookLiterarySubgenres).HasForeignKey(p => p.PublicationId).OnDelete(DeleteBehavior.Cascade);
        _ = builder.Property(p => p.PublicationId).HasColumnOrder(0).IsRequired();
        _ = builder.HasOne(p => p.LiterarySubgenre).WithMany(p => p.BookLiterarySubgenres).HasForeignKey(p => p.LiterarySubgenreId);
        _ = builder.Property(p => p.LiterarySubgenreId).HasColumnOrder(1).IsRequired();
    }
}