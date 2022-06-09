namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class CountryConfiguration : BaseSchema, IEntityTypeConfiguration<Country>
{
    internal CountryConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Country> builder)
    {
        _ = builder.ToTable(nameof(Country), _schema).HasKey(p => p.CountryId);
        _ = builder.Property(p => p.CountryId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(120).IsRequired();
        _ = builder.Property(p => p.AlphaCodeTwo).HasColumnOrder(2).HasMaxLength(2).IsRequired();
        _ = builder.Property(p => p.AlphaCodeThree).HasColumnOrder(3).HasMaxLength(3).IsRequired();
        _ = builder.Property(p => p.NumericCode).HasColumnOrder(4).HasMaxLength(3).IsRequired();
        _ = builder.Property(p => p.ImageUri).HasColumnOrder(5).HasMaxLength(2000).IsRequired();
    }
}