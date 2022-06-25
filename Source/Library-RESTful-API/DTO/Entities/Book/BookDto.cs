using DTO.Entities.Language;
using DTO.Entities.Publisher;

namespace DTO.Entities.Book;

/// <summary>
/// Data Transfer Object [DTO - Output]
/// </summary>
public sealed record BookOutputDto(int PublicationId, string Isbn, LanguageOutputDto Language, string Title, PublisherOutputDto Publisher, DateTime PublicationDate, short Pages, string Description, string ImageUri) : BookBaseDto(Isbn, Title, PublicationDate, Pages, Description, ImageUri);

/// <summary>
/// Data Transfer Object [DTO - Input]
/// </summary>
public sealed record BookInputDto(string Isbn, short LanguageId, string Title, ushort PublisherId, DateTime PublicationDate, short Pages, string Description, string ImageUri) : BookBaseDto(Isbn, Title, PublicationDate, Pages, Description, ImageUri);