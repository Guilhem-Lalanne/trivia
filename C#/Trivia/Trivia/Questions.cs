using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    class Questions
    {
        private readonly Categories _categories = new Categories();

        // Tableau de listes de questions par catégorie
        public List<LinkedList<string>> Tab = new List<LinkedList<string>>();

        public Questions()
        {
            // Décompte des catégories pour bouclage :
            var end = _categories.categories.Count();

            // Pour chaque catégorie, création d'une liste (tas de cartes), inclue dans le tableau
            for (var j = 0; j < end; j++)
            {
                // Déclaration d'une liste de question (selon catégorie)
                Tab.Add(new LinkedList<string>());

                // Remplissage des questions pour la catégorie en cours
                // TODO : à finir
                for (var i = 0; i < 50; i++)
                {
                    Tab[j].AddLast(_categories.categories[j] + " Question " + i);
                }
            }
            
        }

        // Question dépendant de la place
        public void AskQuestion(int currentPlayerPlace)
        {
            // Détermniation de la catgorie, en fonction de la place
            // TODO : calquer numéro de place sur numéro de catégorie
            Console.WriteLine("The category is " + _categories.CurrentCategory(currentPlayerPlace));

            // TODO : prendre l'entier de référence de la catégorie en paramètre
            if (_categories.CurrentCategory(currentPlayerPlace) == "Pop")
            {
                Console.WriteLine(Tab[0].First());
                Tab[0].RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Science")
            {
                Console.WriteLine(Tab[1].First());
                Tab[1].RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Sports")
            {
                Console.WriteLine(Tab[2].First());
                Tab[2].RemoveFirst();
            }
            if (_categories.CurrentCategory(currentPlayerPlace) == "Rock")
            {
                Console.WriteLine(Tab[3].First());
                Tab[3].RemoveFirst();
            }
        }

    }
}
