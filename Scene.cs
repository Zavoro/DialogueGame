using System;
using System.Collections.Generic;
using System.Text;

namespace DialogueGame
{
    public class Scene
    {
        public string Description { get; set; }

        public Scene(string room)
        {
            this.Description = room;
        }
    }
}
