namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class AuthorLiterarySubgenreConfiguration : BaseSchema, IEntityTypeConfiguration<AuthorLiterarySubgenre>
{
    internal AuthorLiterarySubgenreConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<AuthorLiterarySubgenre> builder)
    {
        _ = builder.ToTable(nameof(AuthorLiterarySubgenre), _schema).HasKey(p => new { p.AuthorId, p.LiterarySubgenreId });
        _ = builder.HasOne(p => p.Author).WithMany(p => p.AuthorLiterarySubgenres).HasForeignKey(p => p.AuthorId);
        _ = builder.Property(p => p.AuthorId).HasColumnOrder(0).IsRequired();
        _ = builder.HasOne(p => p.LiterarySubgenre).WithMany(p => p.AuthorLiterarySubgenres).HasForeignKey(p => p.LiterarySubgenreId);
        _ = builder.Property(p => p.LiterarySubgenreId).HasColumnOrder(1).IsRequired();
    }
}