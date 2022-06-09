namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class PublisherConfiguration : BaseSchema, IEntityTypeConfiguration<Publisher>
{
    internal PublisherConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        _ = builder.ToTable(nameof(Publisher), _schema).HasKey(p => p.PublisherId);
        _ = builder.Property(p => p.PublisherId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(90).IsRequired();
        _ = builder.HasOne(p => p.Country).WithMany(p => p.Publishers).HasForeignKey(p => p.CountryId);
        _ = builder.Property(p => p.CountryId).HasColumnOrder(2).IsRequired();
        _ = builder.Property(p => p.Status).HasColumnOrder(3).IsRequired();
    }
}