using Data.Clients.Entities;

namespace Data.Clients;

#pragma warning disable

/// <summary>
/// Manager [client] | [Repository - Implementation]
/// </summary>
public sealed class RepositoryManager : IRepositoryManager
{
    private readonly LibraryDbContext _context;

    private CountryRepository _country;

    public ICountryRepository<short> Country => _country ??= new CountryRepository(_context);

    private AuthorRepository _author;

    public IAuthorRepository<int> Author => _author ??= new AuthorRepository(_context);

    private LiteraryGenreRepository _literaryGenre;

    public ILiteraryGenreRepository<short> LiteraryGenre => _literaryGenre ??= new LiteraryGenreRepository(_context);

    private LiterarySubgenreRepository _literarySubgenre;

    public ILiterarySubgenreRepository<short> LiterarySubgenre => _literarySubgenre ??= new LiterarySubgenreRepository(_context);

    private PublisherRepository _publisher;

    public IPublisherRepository<ushort> Publisher => _publisher ??= new PublisherRepository(_context);

    private LanguageRepository _language;

    public ILanguageRepository<short> Language => _language ??= new LanguageRepository(_context);

    private BookRepository _book;

    public IBookRepository<int> Book => _book ??= new BookRepository(_context);

    private MagazineRepository _magazine;

    public IMagazineRepository<int> Magazine => _magazine ??= new MagazineRepository(_context);

    private FormatRepository _format;

    public IFormatRepository<short> Format => _format ??= new FormatRepository(_context);

    public RepositoryManager(LibraryDbContext context) => _context = context;
}