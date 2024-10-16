using Microsoft.Maui.Controls;
using System;

namespace ScriptWriterApp.Views
{
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        // Create a new script
        private async void OnStartWritingClicked(object sender, EventArgs e)
        {
            string scriptName = ScriptNameEntry.Text;

            if (string.IsNullOrWhiteSpace(scriptName))
            {
                await DisplayAlert("Error", "Please enter a script name", "OK");
            }
            else
            {
                // Navigate to MainPage with scriptName and filePath (can be an empty string if no file)
                await Navigation.PushAsync(new MainPage(scriptName, string.Empty));
            }
        }

        // Load an existing script
        private async void OnLoadScriptClicked(object sender, EventArgs e)
        {
            // Logic to select a script file path, and then navigate to MainPage
            string filePath = "path/to/loaded/script.txt";  // This can be dynamically selected by the user
            string scriptName = "Loaded Script"; // Get script name from the file or user input

            await Navigation.PushAsync(new MainPage(scriptName, filePath));
        }

        private async void OnStartScriptClicked(object sender, EventArgs e)
        {
            string scriptName = ScriptNameEntry.Text;

            if (string.IsNullOrWhiteSpace(scriptName))
            {
                await DisplayAlert("Error", "Script name is required", "OK");
                return;
            }

            // Save script name and navigate to SceneForm
            await Navigation.PushAsync(new SceneForm());
        }

    }
}
