namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class BookConfiguration : BaseSchema, IEntityTypeConfiguration<Book>
{
    internal BookConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Book> builder)
    {
        _ = builder.ToTable(nameof(Book), _schema).HasKey(p => p.PublicationId);
        _ = builder.HasOne(p => p.Publication).WithOne(p => p.Book).HasForeignKey<Book>(p => p.PublicationId);
        _ = builder.Property(p => p.PublicationId).HasColumnOrder(0).IsRequired();
        _ = builder.Property(p => p.Isbn).HasColumnOrder(1).HasMaxLength(17).IsRequired();
        _ = builder.HasOne(p => p.Language).WithMany(p => p.Books).HasForeignKey(p => p.LanguageId);
        _ = builder.Property(p => p.LanguageId).HasColumnOrder(2).IsRequired();
        _ = builder.Property(p => p.Title).HasColumnOrder(3).HasMaxLength(110).IsRequired();
        _ = builder.HasOne(p => p.Publisher).WithMany(p => p.Books).HasForeignKey(p => p.PublisherId);
        _ = builder.Property(p => p.PublisherId).HasColumnOrder(4).IsRequired();
        _ = builder.Property(p => p.PublicationDate).HasColumnOrder(5).IsRequired();
        _ = builder.Property(p => p.Pages).HasColumnOrder(6).HasMaxLength(4).IsRequired();
        _ = builder.Property(p => p.Description).HasColumnOrder(7).HasMaxLength(2000).IsRequired();
        _ = builder.Property(p => p.ImageUri).HasColumnOrder(8).HasMaxLength(2000).IsRequired();
    }
}