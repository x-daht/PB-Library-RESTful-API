namespace DTO.Entities;

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record CountryBaseDto(string Name, string AlphaCodeTwo, string AlphaCodeThree, short NumericCode, string ImageUri);

/// <summary>
/// Base Data Transfer Object [Abstract - DTO]
/// </summary>
public abstract record AuthorBaseDto(string Names, string Surnames, string Description, string ImageUri);