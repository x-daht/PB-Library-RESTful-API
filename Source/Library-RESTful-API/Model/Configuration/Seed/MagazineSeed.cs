namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class MagazineSeed : IEntityTypeConfiguration<Magazine>
{
    internal MagazineSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Magazine> builder) =>
        _ = builder.HasData(
            new Magazine(6, "07321678", 21, "Colored Illustrations and Popular Descriptions of Plants", new DateTime(1997, 08, 05), 88, "It is a magazine with botanical illustrations and descriptions that has been published in New York since 1916", "https://upload.wikimedia.org/wikipedia/commons/6/6e/Rudbeckia_laciniata.jpg"),
            new Magazine(7, "10457356", 21, "Occasional Papers", new DateTime(1948, 05, 22), 67, "Is a magazine with botanical illustrations and descriptions that was edited in Los Angeles. 29 issues were published between 1948 and 1965, superseded by Occasional Papers of the Allan Hancock Foundation", "https://images-na.ssl-images-amazon.com/images/I/4106obu36FL._SX331_BO1,204,203,200_.jpg")
            );
}