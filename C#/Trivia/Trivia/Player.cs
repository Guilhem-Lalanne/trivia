using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trivia
{
    internal class Player
    {
        public Player(string name)
        {
            /**
             * Guid : Globally Unique Id
             * La méthode NewGuid() en crée un automatiquement.
             */
            this.Id = Guid.NewGuid();
            this.Name = name;
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }


    }
}
