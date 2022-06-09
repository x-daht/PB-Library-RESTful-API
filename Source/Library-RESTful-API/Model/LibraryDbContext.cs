using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Model.Configuration;

namespace Model;

#pragma warning disable

/// <summary>
/// Application database context                   
/// </summary>
public sealed class LibraryDbContext : IdentityDbContext
{
    public DbSet<Country> Countries { get; set; }

    public DbSet<Author> Authors { get; set; }

    public DbSet<LiteraryGenre> LiteraryGenres { get; set; }

    public DbSet<LiterarySubgenre> LiterarySubgenres { get; set; }

    public DbSet<AuthorLiterarySubgenre> AuthorLiterarySubgenres { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Language> Languages { get; set; }

    public DbSet<Publication> publications { get; set; }

    public DbSet<Book> Books { get; set; }

    public DbSet<BookLiterarySubgenre> BookLiterarySubgenres { get; set; }

    public DbSet<AuthorBook> AuthorBooks { get; set; }

    public DbSet<Magazine> Magazines { get; set; }

    public DbSet<Format> Formats { get; set; }

    public DbSet<PublicationFormat> PublicationFormats { get; set; }

    public LibraryDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.CreateSqlServerConnection("f81da87e-68f6-4ee1-80de-a7f7051f0466", "DefaultConnection", "Model");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(Schema.dev);
        builder.ApplySeed();
    }
}