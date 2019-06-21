namespace Chunky.Data.Model
{
    public class Word
    {
        public int Id { get; set; }
        public string OriginalText { get; set; }
        public string Translatedtext { get; set; }
        public string ExampleSentence { get; set; }
        public string Definition { get; set; }
        public int DeckId { get; set; }
        public virtual Deck Deck { get; set; }


    }
}