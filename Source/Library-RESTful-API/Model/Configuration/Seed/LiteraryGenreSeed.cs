namespace Model.Configuration.Seed;

/// <summary>
/// Entity Seed
/// </summary>
internal sealed class LiteraryGenreSeed : IEntityTypeConfiguration<LiteraryGenre>
{
    internal LiteraryGenreSeed()
    {
    }

    public void Configure(EntityTypeBuilder<LiteraryGenre> builder) =>
        _ = builder.HasData(
            new LiteraryGenre(1, "Narrative", "Literary genre in which the author presents legendary facts, generally passing them off as true or based on the truth"),
            new LiteraryGenre(2, "Lyrical", "Literary genre in which the author conveys feelings, emotions or sensations regarding a person or object of inspiration"),
            new LiteraryGenre(3, "Dramatic", "Literary genre linked mainly to theater, is one that represents an episode or conflict in the lives of human beings through the dialogue of the characters"),
            new LiteraryGenre(4, "Didactic", "Literary genre whose purpose is the teaching or dissemination of ideas expressed in an artistic way, with an elaborate language and resources of philosophy"),
            new LiteraryGenre(5, "Journalistic", "Style characterized by its source of diffusion, such as the modern media and the written press")
            );
}