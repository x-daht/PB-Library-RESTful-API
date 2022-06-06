namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class LiterarySubgenreSeed : IEntityTypeConfiguration<LiterarySubgenre>
{
    internal LiterarySubgenreSeed()
    {
    }

    public void Configure(EntityTypeBuilder<LiterarySubgenre> builder) =>
        _ = builder.HasData(
             new LiterarySubgenre(1, "Novel", 1, "literary work in prose in which a feigned action is narrated in whole or in part, and whose object is to provide readers with aesthetic pleasure by describing or representing interesting facts or events, as well as characters, passions and customs"),
            new LiterarySubgenre(2, "Story", 1, "Short story based or not on real events, inspired or not by previous writings or legends, whose plot is carried out by a small group of characters, and which has a relatively simple plot"),
            new LiterarySubgenre(3, "Fable", 1, "short literary composition in which the characters are almost always animals that have human characteristics such as speech"),
            new LiterarySubgenre(4, "Legend", 1, "Narrative about supernatural, natural events or a mixture of both that is transmitted from generation to generation, orally or in writing"),
            new LiterarySubgenre(5, "Epic", 1, "Literary composition in verse in which the legendary deeds of heroic characters are narrated, which generally form part of the origin of a lineage or a people"),
            new LiterarySubgenre(6, "Epic poem", 1, "It consists of an extensive story that generally deals with great heroic deeds, in which the author tries to objectively present real or fictitious events that occurred in a specific space and time frame"),
            new LiterarySubgenre(7, "Eclogue", 2, "Poetic composition that idealizes the life of shepherds and the countryside to deal with general human themes"),
            new LiterarySubgenre(8, "Elegy", 2, "Poetic composition of the lyrical genre in which the death of a person or other misfortune is lamented and that does not have a fixed metrical form"),
            new LiterarySubgenre(9, "Oda", 2, "reflective and meditative poem that tends to exalt and praise a theme or matter"),
            new LiterarySubgenre(10, "Satire", 2, "Speech or literary composition in prose or verse in which the customs or vices of someone with a moralizing, playful or merely burlesque intention are harshly criticized"),
            new LiterarySubgenre(11, "Sonnet", 2, "Poetic composition formed by fourteen verses of major art, generally hendecasyllables, and rhyme, which are divided into two quatrains and two triplets"),
            new LiterarySubgenre(12, "Madrigal", 2, "Lyrical composition that combines heptasyllable and hendecasyllable verses with rhyme, generally with a love theme"),
            new LiterarySubgenre(13, "Song", 2, "Poem of admiration that expresses an emotion or feeling"),
            new LiterarySubgenre(14, "Epigram", 2, "Poignant and concise poem, usually written in verse"),
            new LiterarySubgenre(15, "Anacreontic", 2, "lyrical composition in verse of minor art that sings to the pleasures of life, wine and love"),
            new LiterarySubgenre(16, "Hymn", 2, "Song or a lyrical text that expresses positive feelings, joy and celebration"),
            new LiterarySubgenre(17, "Tragedy", 3, "Work in which the main characters are confronted in a mysterious, invincible and inevitable way against destiny or the gods"),
            new LiterarySubgenre(18, "Comedy", 3, "Work that presents a majority of humorous or festive scenes and situations"),
            new LiterarySubgenre(19, "Melodrama", 3, "Composition in which the sentimental, pathetic or tearful aspects of the work are exaggerated with the intention of provoking emotions in the public"),
            new LiterarySubgenre(20, "Tragicomedy", 3, "Composition in which the tragic and comic elements are mixed, although there is also room for sarcasm and parody"),
            new LiterarySubgenre(21, "Farce", 3, "Composition whose structure and plot are based on situations in which the characters behave in an extravagant and strange way, although generally maintaining a share of credibility"),
            new LiterarySubgenre(22, "Sainete", 3, "Brief theatrical piece with a humorous theme and generally of a popular character"),
            new LiterarySubgenre(23, "Entremes", 3, "Comic piece or play in one act, written in verse or prose, which was performed between the first and second days of the comedies of the Spanish classical theater"),
            new LiterarySubgenre(24, "Essay", 4, "Type of prose text that explores, analyzes, interprets or evaluates a topic"),
            new LiterarySubgenre(25, "Biography", 4, "Story of the life of a person narrated by another person, that is, in the full sense from birth to death"),
            new LiterarySubgenre(26, "Chronicle", 4, "It consists of the compilation of historical facts narrated in chronological order according to the times"),
            new LiterarySubgenre(27, "Written memory", 4, "Type of text that describes in detail activities and projects that are going to be carried out in the future, or those that have already been carried out"),
            new LiterarySubgenre(28, "Oratory", 4, "Genre formed by the speech, the harangue, the dissertation, the sermon, the elegy, among others"),
            new LiterarySubgenre(29, "Epistle", 4, "Text whose main function is communication between the sender or issuer (the writer who writes and sends it) and the addressee or receiver"),
            new LiterarySubgenre(30, "Treaty", 4, "It consists of a comprehensive, objective and orderly exposition of knowledge on a specific subject or topic"),
            new LiterarySubgenre(31, "Didactic novel", 4, "Novel that seeks to teach or impart some kind of knowledge on a particular subject to readers"),
            new LiterarySubgenre(32, "Didactic poem", 4, "Poem whose function is teaching"),
            new LiterarySubgenre(33, "Literary dialogue", 4, "Cognitive instrument to find the truth philosophy through debate (dialectic) in the company of other procedures such as irony and maieutics"),
            new LiterarySubgenre(34, "Aphorism", 4, "Sentence that tries to express an idea in a concise, coherent and apparently definitive way"),
            new LiterarySubgenre(35, "Scientific article", 4, "Academic text that shows compliance with specific regulations both in its general structure and in its content"),
            new LiterarySubgenre(36, "Reportage", 5, "Detailed journalistic narrative of a fact or event in a given context")
            );
}