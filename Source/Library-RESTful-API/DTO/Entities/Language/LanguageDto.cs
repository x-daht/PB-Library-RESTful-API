namespace DTO.Entities.Language;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record LanguageOutputDto(short LanguageId, string Name) : LanguageBaseDto(Name);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record LanguageInputDto(string Name) : LanguageBaseDto(Name);