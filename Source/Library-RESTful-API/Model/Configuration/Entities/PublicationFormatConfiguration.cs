namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class PublicationFormatConfiguration : BaseSchema, IEntityTypeConfiguration<PublicationFormat>
{
    internal PublicationFormatConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<PublicationFormat> builder)
    {
        _ = builder.ToTable(nameof(PublicationFormat), _schema).HasKey(p => new { p.PublicationId, p.FormatId });
        _ = builder.HasOne(p => p.Publication).WithMany(p => p.PublicationFormats).HasForeignKey(p => p.PublicationId);
        _ = builder.Property(p => p.PublicationId).HasColumnOrder(0).IsRequired();
        _ = builder.HasOne(p => p.Format).WithMany(p => p.PublicationFormats).HasForeignKey(p => p.FormatId);
        _ = builder.Property(p => p.FormatId).HasColumnOrder(1).IsRequired();
    }
}