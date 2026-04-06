using System;
using System.Collections.Generic;
using System.Text;

namespace DialogueGame
{
    public class Player
    {
        string name = "Unknown";
        int health = 100;
        List<string> inventory = new List<string>();

        public void AddItem(string item)
        {
            inventory.Add(item);
        }

        public bool HasItem(string item)
        {
            return inventory.Contains(item);
        }

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
        }
    }

    
}
