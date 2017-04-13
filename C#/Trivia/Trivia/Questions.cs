using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class Questions
    {
        private readonly Categories _categories = new Categories();

        LinkedList<string> popQuestions = new LinkedList<string>();
        LinkedList<string> scienceQuestions = new LinkedList<string>();
        LinkedList<string> sportsQuestions = new LinkedList<string>();
        LinkedList<string> rockQuestions = new LinkedList<string>();

        public Questions()
        {
            for (var i = 0; i < 50; i++)
            {
                popQuestions.AddLast("Pop Question " + i);
                scienceQuestions.AddLast("Science Question " + i);
                sportsQuestions.AddLast("Sports Question " + i);
                rockQuestions.AddLast("Rock Question " + i);
            }
        }

        // Question dépendant de la place
        public void AskQuestion(int currentPlayerPlace)
        {
            // Détermniation de la catgorie, en fonction de la place
            Console.WriteLine("The category is " + _categories.CurrentCategory(currentPlayerPlace));

            if (_categories.CurrentCategory(currentPlayerPlace) == "Pop")
            {
                Console.WriteLine(popQuestions.First());
                popQuestions.RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Science")
            {
                Console.WriteLine(scienceQuestions.First());
                scienceQuestions.RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Sports")
            {
                Console.WriteLine(sportsQuestions.First());
                sportsQuestions.RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Rock")
            {
                Console.WriteLine(rockQuestions.First());
                rockQuestions.RemoveFirst();
            }
        }

    }
}
