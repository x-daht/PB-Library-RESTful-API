namespace Data.Contracts;

/// <summary>
/// Manager [contract] | [Repository - Declaration]
/// </summary>
public interface IRepositoryManager
{
    ICountryRepository<short> Country { get; }

    IAuthorRepository<int> Author { get; }

    ILiteraryGenreRepository<short> LiteraryGenre { get; }

    ILiterarySubgenreRepository<short> LiterarySubgenre { get; }

    IPublisherRepository<ushort> Publisher { get; }

    ILanguageRepository<short> Language { get; }

    IBookRepository<int> Book { get; }

    IMagazineRepository<int> Magazine { get; }

    IFormatRepository<short> Format { get; }
}