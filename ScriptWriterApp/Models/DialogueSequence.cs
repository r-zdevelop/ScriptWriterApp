using System.Collections.Generic;

namespace ScriptWriterApp.Models
{
    public class DialogueSequence
    {
        public List<DialogueLine> Lines { get; set; } // List of lines spoken in the sequence

        public DialogueSequence()
        {
            Lines = new List<DialogueLine>();
        }
    }

    public class DialogueLine
    {
        public Character Character { get; set; }
        public string Line { get; set; }
    }
}
