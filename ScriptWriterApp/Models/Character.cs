namespace ScriptWriterApp.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Age { get; set; } // Age can be uncertain, e.g., "30", "Unknown"
    }
}
