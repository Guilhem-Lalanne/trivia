using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    public class Game
    {

        private readonly Players _players;
        private readonly Questions _questions = new Questions();

        bool isGettingOutOfPenaltyBox;


        public Game(Players players)
        {
            _players = players;

            
        }
        
        

        public void Roll(int roll)
        {
            Console.WriteLine(_players.Current.Name + " is the current player");
            Console.WriteLine("They have rolled a " + roll);

            if (_players.Current.InPenaltyBox)
            {
                // Si roll impair
                if (roll % 2 != 0)
                {
                    // Sort de pénalité
                    isGettingOutOfPenaltyBox = true;

                    Console.WriteLine(_players.Current.Name + " is getting out of the penalty box");
                    // Déplacement du joueur courant
                    _players.Current.Move(roll);

                    Console.WriteLine(_players.Current.Name
                            + "'s new location is "
                            + _players.Current.Place);
                   
                    // On lui pose une question
                    _questions.AskQuestion(_players.Current.Place);
                }
                else
                {
                    Console.WriteLine(_players.Current.Name + " is not getting out of the penalty box");
                    isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                // Déplacement du joueur courant
                _players.Current.Move(roll);

                Console.WriteLine(_players.Current.Name
                        + "'s new location is "
                        + _players.Current.Place);

                // On lui pose une question
                _questions.AskQuestion(_players.Current.Place);
            }

        }

        public bool WasCorrectlyAnswered()
        {
            bool winner;
            if (_players.Current.InPenaltyBox)
            {
                // Sort de pénalité
                if (isGettingOutOfPenaltyBox)
                {
                    Console.WriteLine("Answer was correct!!!!");
                    _players.Current.WinAGoldCoin();

                    // Gagne 
                    winner = _players.Current.IsWinner();
                    // Passage au joueur suivant
                    _players.NextPlayer();

                    return winner;
                }

                // Passage au joueur suivant
                _players.NextPlayer();
                return false;
            }

            Console.WriteLine("Answer was corrent!!!!");
            _players.Current.WinAGoldCoin();

            // NB : winner = true si GoldCoins == 6
            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            Console.WriteLine("Question was incorrectly answered");
            Console.WriteLine(_players.Current.Name + " was sent to the penalty box");
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }
}
