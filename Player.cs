using System;
using System.Collections.Generic;
using System.Text;

namespace DialogueGame
{
    public class Player
    {

        string name = "Unknown";
        int health = 100;
        List<DecisionsMade> decisions = new List<DecisionsMade>();
        List<string> inventory = new List<string>();

        public void AddItem(string item)
        {
            inventory.Add(item);
        }

        public bool HasItem(string item)
        {
            return inventory.Contains(item);
        }

        public void RecordDecision(DecisionsMade decision)
        {
            decisions.Add(decision);
        }
        
        public bool CheckDecision(DecisionsMade decision)
        {
            return decisions.Contains(decision);
        }

        public Player(string name)
        {
            this.name = name;
            this.health = 100;
            this.decisions = new List<DecisionsMade>();

        }
    }

    public enum DecisionsMade
    {
        StayedSilent,
        QuestionedMan
    }


}
