using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashcardApp.Data
{
    public class Flashcard
    {
        public int ID { get; set; }
        public string Term { get; set; }
        public string Description { get; set; }
        public bool Favorite { get; set; }
        public int MissedCount { get; set; }
        public int CorrectCount { get; set; }
    }
}
