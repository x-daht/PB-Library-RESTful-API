namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class MagazineConfiguration : BaseSchema, IEntityTypeConfiguration<Magazine>
{
    internal MagazineConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Magazine> builder)
    {
        _ = builder.ToTable(nameof(Magazine), _schema).HasKey(p => p.PublicationId);
        _ = builder.HasOne(p => p.Publication).WithOne(p => p.Magazine).HasForeignKey<Magazine>(p => p.PublicationId);
        _ = builder.Property(p => p.PublicationId).HasColumnOrder(0).IsRequired();
        _ = builder.Property(p => p.Issn).HasColumnOrder(1).HasMaxLength(9).IsRequired();
        _ = builder.HasOne(p => p.Language).WithMany(p => p.Magazines).HasForeignKey(p => p.LanguageId);
        _ = builder.Property(p => p.LanguageId).HasColumnOrder(2).IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(3).HasMaxLength(120).IsRequired();
        _ = builder.Property(p => p.PublicationDate).HasColumnOrder(4).IsRequired();
        _ = builder.Property(p => p.Pages).HasColumnOrder(5).HasMaxLength(3).IsRequired();
        _ = builder.Property(p => p.Description).HasColumnOrder(6).HasMaxLength(2000).IsRequired();
        _ = builder.Property(p => p.ImageUri).HasColumnOrder(7).HasMaxLength(2000).IsRequired();
    }
}