namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class FormatConfiguration : BaseSchema, IEntityTypeConfiguration<Format>
{
    internal FormatConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Format> builder)
    {
        _ = builder.ToTable(nameof(Format), _schema).HasKey(p => p.FormatId);
        _ = builder.Property(p => p.FormatId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(20).IsRequired();
    }
}