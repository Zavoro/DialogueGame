using System;
using System.Collections.Generic;
using System.Text;

namespace DialogueGame
{
    public class Player
    {
        string name = "Unknown";
        int health = 100;
        //inventory - to be implemented in Issue #6  

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
        }
    }

    
}
