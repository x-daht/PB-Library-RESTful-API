using DTO.Entities.Language;

namespace DTO.Entities.Magazine;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record MagazineOutputDto(int PublicationId, string Issn, LanguageOutputDto Language, string Name, DateTime PublicationDate, short Pages, string Description, string ImageUri) : MagazineBaseDto(Issn, Name, PublicationDate, Pages, Description, ImageUri);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record MagazineInputDto(string Issn, short LanguageId, string Name, DateTime PublicationDate, short Pages, string Description, string ImageUri) : MagazineBaseDto(Issn, Name, PublicationDate, Pages, Description, ImageUri);