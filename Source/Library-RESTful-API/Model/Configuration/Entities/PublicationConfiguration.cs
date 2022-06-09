namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class PublicationConfiguration : BaseSchema, IEntityTypeConfiguration<Publication>
{
    internal PublicationConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Publication> builder)
    {
        _ = builder.ToTable(nameof(Publication), _schema).HasKey(p => p.PublicationId);
        _ = builder.Property(p => p.PublicationId).ValueGeneratedOnAdd().IsRequired();
    }
}