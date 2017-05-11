using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashcardApp.Data
{
    class FlashcardSet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalCards { get; set; }
        public List<Flashcard> Flashcards { get; set; }

        static int CountCards(List<Flashcard> flashcards)
        {
            int totalCards = 0;

            foreach (var fc in flashcards)
            {
                totalCards++;
            }

            return totalCards;
        }
    }
}
