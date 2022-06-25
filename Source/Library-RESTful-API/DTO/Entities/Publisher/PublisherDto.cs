using DTO.Entities.Country;

namespace DTO.Entities.Publisher;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record PublisherOutputDto(ushort PublisherId, string Name, CountryOutputDto Country, bool Status) : PublisherBaseDto(Name, Status);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record PublisherInputDto(string Name, short CountryId, bool Status) : PublisherBaseDto(Name, Status);