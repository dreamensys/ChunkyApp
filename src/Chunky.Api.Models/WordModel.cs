using System;
using System.Collections.Generic;
using System.Text;

namespace Chunky.Api.Models
{
    public class WordModel
    {
        public int Id { get; set; }
        public string OriginalText { get; set; }
        public string Translatedtext { get; set; }
        public string ExampleSentence { get; set; }
        public string Definition { get; set; }
        public int DeckId { get; set; }
    }
}
