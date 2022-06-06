namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class LanguageConfiguration : BaseSchema, IEntityTypeConfiguration<Language>
{
    internal LanguageConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Language> builder)
    {
        _ = builder.ToTable(nameof(Language), _schema).HasKey(p => p.LanguageId);
        _ = builder.Property(p => p.LanguageId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(50).IsRequired();
    }
}