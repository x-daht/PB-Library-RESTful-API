using DTO.Entities.Country;

namespace DTO.Entities.Author;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record AuthorOutputDto(int AuthorId, string Names, string Surnames, CountryOutputDto Country, string Description, string ImageUri) : AuthorBaseDto(Names, Surnames, Description, ImageUri);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record AuthorInputDto(string Names, string Surnames, short CountryId, string Description, string ImageUri) : AuthorBaseDto(Names, Surnames, Description, ImageUri); 