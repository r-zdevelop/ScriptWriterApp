using System.Collections.Generic;

namespace ScriptWriterApp.Models
{
    public class Scene
    {
        public string Title { get; set; }
        public Stage Stage { get; set; }
        public string TimeOfDay { get; set; } // e.g., "Day", "Evening", "Night"
        public string Description { get; set; }
        public List<Character> Characters { get; set; }
        public List<DialogueSequence> DialogueSequences { get; set; }

        public Scene()
        {
            Characters = new List<Character>();
            DialogueSequences = new List<DialogueSequence>();
        }
    }
}
