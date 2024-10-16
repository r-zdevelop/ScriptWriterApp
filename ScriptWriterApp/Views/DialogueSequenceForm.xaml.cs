using Microsoft.Maui.Controls;
using ScriptWriterApp.Models;

namespace ScriptWriterApp.Views
{
    public partial class DialogueSequenceForm : ContentPage
    {
        public DialogueSequenceForm()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string characterName = CharacterEntry.Text;
            string dialogueLine = DialogueEditor.Text;

            if (string.IsNullOrWhiteSpace(characterName))
            {
                await DisplayAlert("Error", "Character name is required", "OK");
                return;
            }

            // Create a new character and dialogue line
            Character character = new Character { Name = characterName };
            DialogueLine line = new DialogueLine
            {
                Character = character,
                Line = dialogueLine
            };

            // Save or pass the dialogue line
            await DisplayAlert("Success", $"Dialogue for {characterName} saved!", "OK");
        }
    }
}
