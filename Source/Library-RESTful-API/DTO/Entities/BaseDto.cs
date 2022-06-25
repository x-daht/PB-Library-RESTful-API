namespace DTO.Entities;

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record CountryBaseDto(string Name, string AlphaCodeTwo, string AlphaCodeThree, short NumericCode, string ImageUri);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record AuthorBaseDto(string Names, string Surnames, string Description, string ImageUri);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record LiteraryGenreBaseDto(string Name, string Description);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record LiterarySubgenreBaseDto(string Name, string Description);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record PublisherBaseDto(string Name, bool Status);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record LanguageBaseDto(string Name);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record BookBaseDto(string Isbn, string Title, DateTime PublicationDate, short Pages, string Description, string ImageUri);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record MagazineBaseDto(string Issn, string Name, DateTime PublicationDate, short Pages, string Description, string ImageUri);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record FormatBaseDto(string Name);