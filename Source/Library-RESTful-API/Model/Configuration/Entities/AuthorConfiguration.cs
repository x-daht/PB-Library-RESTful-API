namespace Model.Configuration.Entities;

/// <summary>
/// Entity configuration
/// </summary>
internal sealed class AuthorConfiguration : BaseSchema, IEntityTypeConfiguration<Author>
{
    internal AuthorConfiguration(Schema schema) : base(schema)
    {
    }

    public void Configure(EntityTypeBuilder<Author> builder)
    {
        _ = builder.ToTable(nameof(Author), _schema).HasKey(p => p.AuthorId);
        _ = builder.Property(p => p.AuthorId).HasColumnOrder(0).ValueGeneratedOnAdd().IsRequired();
        _ = builder.Property(p => p.Names).HasColumnOrder(1).HasMaxLength(90).IsRequired();
        _ = builder.Property(p => p.Surnames).HasColumnOrder(2).HasMaxLength(120).IsRequired();
        _ = builder.HasOne(p => p.Country).WithMany(p => p.Authors).HasForeignKey(p => p.CountryId);
        _ = builder.Property(p => p.CountryId).HasColumnOrder(3).IsRequired();
        _ = builder.Property(p => p.Description).HasColumnOrder(4).HasMaxLength(2000).IsRequired();
        _ = builder.Property(p => p.ImageUri).HasColumnOrder(5).HasMaxLength(2000).IsRequired();
    }
}