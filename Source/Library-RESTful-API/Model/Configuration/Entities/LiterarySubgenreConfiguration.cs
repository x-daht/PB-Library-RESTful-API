namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class LiterarySubgenreConfiguration : BaseSchema, IEntityTypeConfiguration<LiterarySubgenre>
{
    internal LiterarySubgenreConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<LiterarySubgenre> builder)
    {
        _ = builder.ToTable(nameof(LiterarySubgenre), _schema).HasKey(p => p.LiterarySubgenreId);
        _ = builder.Property(p => p.LiterarySubgenreId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Name).HasColumnOrder(1).HasMaxLength(40).IsRequired();
        _ = builder.HasOne(p => p.LiteraryGenre).WithMany(p => p.LiterarySubgenres).HasForeignKey(p => p.LiteraryGenreId);
        _ = builder.Property(p => p.LiteraryGenreId).HasColumnOrder(2).IsRequired();
        _ = builder.Property(p => p.Description).HasColumnOrder(3).HasMaxLength(400).IsRequired();
    }
}