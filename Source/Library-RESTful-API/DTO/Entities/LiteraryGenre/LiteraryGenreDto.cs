namespace DTO.Entities.LiteraryGenre;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record LiteraryGenreOutputDto(short LiteraryGenreId, string Name, string Description) : LiteraryGenreBaseDto(Name, Description);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record LiteraryGenreInputDto(string Name, string Description) : LiteraryGenreBaseDto(Name, Description);