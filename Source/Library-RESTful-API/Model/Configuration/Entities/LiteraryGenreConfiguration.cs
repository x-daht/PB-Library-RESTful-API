namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class LiteraryGenreConfiguration : BaseSchema, IEntityTypeConfiguration<LiteraryGenre>
{
    internal LiteraryGenreConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<LiteraryGenre> builder)
    {
        _ = builder.ToTable(nameof(LiteraryGenre), _schema).HasKey(p => p.LiteraryGenreId);
        _ = builder.Property(p => p.LiteraryGenreId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(30).IsRequired();
        _ = builder.Property(p => p.Description).HasColumnOrder(2).HasMaxLength(200).IsRequired();
    }
}