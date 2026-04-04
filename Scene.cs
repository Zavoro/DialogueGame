using System;
using System.Collections.Generic;
using System.Text;

namespace DialogueGame
{
    public class Scene
    {
        public string Description { get; set; }
        public List<string> Choices { get; set; }
        public Scene(string room, List<string> Choices)
        {
            this.Description = room;
            this.Choices = Choices;
        }

        
    }
}
