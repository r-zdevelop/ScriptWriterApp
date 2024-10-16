using Microsoft.Maui.Controls;
using ScriptWriterApp.Models;

namespace ScriptWriterApp.Views
{
    public partial class CharacterForm : ContentPage
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string description = DescriptionEditor.Text;
            string age = AgeEntry.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                await DisplayAlert("Error", "Name is required", "OK");
                return;
            }

            // Create a new character object
            Character newCharacter = new Character
            {
                Name = name,
                Description = description,
                Age = age
            };

            // You can now save the character or pass it to another page
            await DisplayAlert("Success", $"Character {name} saved!", "OK");
        }
    }
}
