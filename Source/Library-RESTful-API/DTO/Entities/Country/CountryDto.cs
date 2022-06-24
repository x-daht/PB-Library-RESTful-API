namespace DTO.Entities.Country;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record CountryOutputDto(short CountryId, string Name, string AlphaCodeTwo, string AlphaCodeThree, short NumericCode, string ImageUri) : CountryBaseDto(Name, AlphaCodeTwo, AlphaCodeThree, NumericCode, ImageUri);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record CountryInputDto(string Name, string AlphaCodeTwo, string AlphaCodeThree, short NumericCode, string ImageUri) : CountryBaseDto(Name, AlphaCodeTwo, AlphaCodeThree, NumericCode, ImageUri);