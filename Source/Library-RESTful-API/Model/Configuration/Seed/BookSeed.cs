namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class BookSeed : IEntityTypeConfiguration<Book>
{
    internal BookSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Book> builder) =>
        _ = builder.HasData(
            new Book(1, "9789875664692", 21, "In Cold Blood", 1, new DateTime(1996, 01, 17), 343, "In Cold Blood recounts the brutal murder of the four members of a Kansas family. In 1959, a violent crime rocked the quiet life of Holcomb, Kansas. The American society of those years was shocked by a crime that suggested that anyone could be killed at any time", "https://upload.wikimedia.org/wikipedia/commons/f/f2/Filmpremiere_in_Du_Midi%2C_In_Koelen_Bloede_%28In_Cold_Blood%29_naar_het_boek_van_%2C_Bestanddeelnr_921-1637.jpg"),
            new Book(2, "9786079759315", 21, "The tell tale heart", 1, new DateTime(1843, 01, 14), 238, "The story features an anonymous narrator obsessed with the diseased eye (which he calls \"vulture eye\") of an old man with whom he lives. He finally decides to kill him. The crime is carefully studied and, after being perpetrated, the body is torn to pieces and hidden under the floorboards of the house", "https://upload.wikimedia.org/wikipedia/commons/4/43/Clarke-TellTaleHeart.jpeg"),
            new Book(3, "9788426423122", 88, "Poet in new york", 3, new DateTime(1940, 04, 02), 264, "Book that builds the poetic image of a subject in crisis. Personal, social and even literary crisis (Lorca was a little tired of being the poet of the Gypsy Ballads). The subject in crisis is not only confronted with the capitalist system. Nature not only confronts civilization, mechanistic society, the inhuman city, the precarious conditions of existence. The poetic subject faces the void on which he has to build his identity", "https://upload.wikimedia.org/wikipedia/commons/b/bc/Autorretrato_Poeta_NY.jpg"),
            new Book(4, "9788497592208", 88, "One hundred years of solitude", 4, new DateTime(1967, 05, 30), 471, "novel that tells the story of the peculiar Buendía family in the town of Macondo. A town founded by the head of the family, and the place where the story begins. A story that unfolds through the adventures and misadventures suffered by the family, generation after generation", "https://upload.wikimedia.org/wikipedia/en/a/a0/Cien_a%C3%B1os_de_soledad_%28book_cover%2C_1967%29.jpg"),
            new Book(5, "9789584291226", 88, "One hundred love sonnets", 5, new DateTime(1959, 08, 14), 124, "One Hundred Sonnets of Love is a collection of poems (they are not really sonnets although they are made up of fourteen hendecasyllable lines of free rhyme), written by the Chilean poet and Nobel Prize winner for Literature Pablo Neruda, originally published in Argentina in 1959", "https://upload.wikimedia.org/wikipedia/en/e/ed/Neruda_100_love_sonnets.jpg")
            );
}