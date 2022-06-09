namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class AuthorSeed : IEntityTypeConfiguration<Author>
{
    internal AuthorSeed()
    {
    }

    public void Configure(EntityTypeBuilder<Author> builder) =>
        _ = builder.HasData(
            new Author(1, "Truman", "Garcia Capote", 186, "Truman García Capote (born Truman Streckfus Persons, September 30, 1924 – August 25, 1984) was an American novelist, screenwriter, playwright, and actor. Several of his short stories, novels, and plays have been praised as literary classics, including the novel Breakfast at Tiffany's (1958) and the true crime novel In Cold Blood (1966), which he called a \"non - fiction novel\". His works have been adapted into more than 20 films and television series", "https://upload.wikimedia.org/wikipedia/commons/3/31/Truman_Capote_by_Jack_Mitchell.jpg"),
            new Author(2, "Edgar", "Allan Poe", 186, "Edgar Allan Poe (January 19, 1809 – October 7, 1849) was an American writer, poet, editor, and literary critic. Poe is best known for his poetry and short stories, particularly his tales of mystery and the macabre. He is widely regarded as a central figure of Romanticism in the United States, and of American literature", "https://upload.wikimedia.org/wikipedia/commons/9/97/Edgar_Allan_Poe%2C_circa_1849%2C_restored%2C_squared_off.jpg"),
            new Author(3, "Federico", "García Lorca", 164, "Federico del Sagrado Corazón de Jesús García Lorca (June 5, 1898 – August 19, 1936), known as Federico García Lorca, was a Spanish poet, playwright and theater director. García Lorca achieved international recognition as an emblematic member of the Generation of '27, a group made up mostly of poets who introduced the principles of European movements (such as Symbolism, Futurism, and Surrealism) into Spanish literature", "https://upload.wikimedia.org/wikipedia/commons/5/5e/Fotograf%C3%ADa_an%C3%B3nima_MNCARS_4.jpg"),
            new Author(4, "Gabriel", "García Márquez", 37, "Gabriel García Márquez (March 6, 1927 – April 17, 2014) was a Colombian novelist, short story writer, screenwriter, and journalist, affectionately known as Gabo or Gabito throughout Latin America. Considered one of the most significant authors of the 20th century, particularly in the Spanish language, he was awarded the 1972 Neustadt International Prize for Literature and the 1982 Nobel Prize for Literature", "https://upload.wikimedia.org/wikipedia/commons/0/0f/Gabriel_Garcia_Marquez.jpg"),
            new Author(5, "Pablo", "Neruda", 35, "Ricardo Eliécer Neftalí Reyes Basoalto (July 12, 1904 - September 23, 1973), better known by his pseudonym, and later as Pablo Neruda (which would be his legal name), was a Chilean poet, diplomat, and politician. Nobel Prize for Literature winner in 1971 Neruda rose to fame as a poet when he was 13, writing in a variety of styles, including surrealist poems, historical epics, overtly political manifestos, a prose autobiography, and passionate love poems like those in his collection. Twenty love poems and a desperate song", "https://upload.wikimedia.org/wikipedia/commons/8/86/Pablo_Neruda_1963.jpg")
            );
}