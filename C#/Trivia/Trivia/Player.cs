using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    public class Player
    {
        public Player(string name)
        {
            /**
             * Guid : Globally Unique Id
             * La méthode NewGuid() en crée un automatiquement.
             */
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Place = 0;
            this.Purse = 0;
            this.IsInPenaltyBox = false;
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int Place { get; private set; }

        public int Purse { get; private set; }

        public bool IsInPenaltyBox { get; private set; }
    }
}
