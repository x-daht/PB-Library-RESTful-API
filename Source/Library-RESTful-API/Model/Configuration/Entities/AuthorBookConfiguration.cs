namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class AuthorBookConfiguration : BaseSchema, IEntityTypeConfiguration<AuthorBook>
{
    internal AuthorBookConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<AuthorBook> builder)
    {
        _ = builder.ToTable(nameof(AuthorBook), _schema).HasKey(p => new { p.AuthorId, p.PublicationId });
        _ = builder.HasOne(p => p.Author).WithMany(p => p.AuthorBooks).HasForeignKey(p => p.AuthorId);
        _ = builder.Property(p => p.AuthorId).HasColumnOrder(0).IsRequired();
        _ = builder.HasOne(p => p.Book).WithMany(p => p.AuthorBooks).HasForeignKey(p => p.PublicationId).OnDelete(DeleteBehavior.ClientCascade);
        _ = builder.Property(p => p.PublicationId).HasColumnOrder(1).IsRequired();
    }
}