using Microsoft.Extensions.Configuration;
using Model.Configuration.Entities;
using Model.Configuration.Seed;

namespace Model.Configuration;

/// <summary>
/// Features extension for the ModelBuilder class
/// </summary>
internal static class ModelExtension
{
    /// <summary>
    /// Extension method [No return value] | Create SQL Server database connection
    /// </summary>
    internal static void CreateSqlServerConnection(this DbContextOptionsBuilder optionsBuilder, string userSecretId, string connectionName, string migrationAssemblyName)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().AddUserSecrets(userSecretId).Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString(connectionName), o => o.MigrationsAssembly(migrationAssemblyName));
        }
    }

    /// <summary>
    /// Extension method [No return value] | Apply entities configuration [Current assembly]
    /// </summary>
    internal static void ApplyConfiguration(this ModelBuilder builder, Schema schema)
    {
        _ = builder.ApplyConfiguration(new CountryConfiguration(schema));
        _ = builder.ApplyConfiguration(new AuthorConfiguration(schema));
        _ = builder.ApplyConfiguration(new LiteraryGenreConfiguration(schema));
        _ = builder.ApplyConfiguration(new LiterarySubgenreConfiguration(schema));
        _ = builder.ApplyConfiguration(new AuthorLiterarySubgenreConfiguration(schema));
        _ = builder.ApplyConfiguration(new PublisherConfiguration(schema));
        _ = builder.ApplyConfiguration(new LanguageConfiguration(schema));
        _ = builder.ApplyConfiguration(new PublicationConfiguration(schema));
        _ = builder.ApplyConfiguration(new BookConfiguration(schema));
        _ = builder.ApplyConfiguration(new BookLiterarySubgenreConfiguration(schema));
        _ = builder.ApplyConfiguration(new AuthorBookConfiguration(schema));
        _ = builder.ApplyConfiguration(new MagazineConfiguration(schema));
        _ = builder.ApplyConfiguration(new FormatConfiguration(schema));
        _ = builder.ApplyConfiguration(new PublicationFormatConfiguration(schema));
    }

    /// <summary>
    /// Extension method [No return value] | Apply seeds configuration [Current assembly]
    /// </summary>
    internal static void ApplySeed(this ModelBuilder builder)
    {
        _ = builder.ApplyConfiguration(new CountrySeed());
        _ = builder.ApplyConfiguration(new AuthorSeed());
        _ = builder.ApplyConfiguration(new LiteraryGenreSeed());
        _ = builder.ApplyConfiguration(new LiterarySubgenreSeed());
        _ = builder.ApplyConfiguration(new AuthorLiterarySubgenreSeed());
        _ = builder.ApplyConfiguration(new PublisherSeed());
        _ = builder.ApplyConfiguration(new LanguageSeed());
        _ = builder.ApplyConfiguration(new PublicationSeed());
        _ = builder.ApplyConfiguration(new BookSeed());
        _ = builder.ApplyConfiguration(new BookLiterarySubgenreSeed());
        _ = builder.ApplyConfiguration(new AuthorBookSeed());
        _ = builder.ApplyConfiguration(new MagazineSeed());
        _ = builder.ApplyConfiguration(new FormatSeed());
        _ = builder.ApplyConfiguration(new PublicationFormatSeed());
    }
}