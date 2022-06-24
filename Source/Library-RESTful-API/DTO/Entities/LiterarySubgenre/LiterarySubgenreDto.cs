using DTO.Entities.LiteraryGenre;

namespace DTO.Entities.LiterarySubgenre;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record LiterarySubgenreOutputDto(short LiterarySubgenreId, string Name, LiteraryGenreOutputDto LiteraryGenre, string Description) : LiterarySubgenreBaseDto(Name, Description);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record LiterarySubgenreInputDto(string Name, short LiteraryGenreId, string Description);