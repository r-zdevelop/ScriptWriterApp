using Microsoft.Maui.Controls;
using ScriptWriterApp.Models;

namespace ScriptWriterApp.Views
{
    public partial class SceneForm : ContentPage
    {
        public SceneForm()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string title = TitleEntry.Text;
            string stageDescription = StageEntry.Text;
            string timeOfDay = TimeOfDayPicker.SelectedItem?.ToString();
            string description = DescriptionEditor.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                await DisplayAlert("Error", "Title is required", "OK");
                return;
            }

            // Create new Stage and Scene objects
            Stage newStage = new Stage
            {
                Description = stageDescription
            };

            Scene newScene = new Scene
            {
                Title = title,
                Stage = newStage,
                TimeOfDay = timeOfDay,
                Description = description
            };

            // Save or pass the scene
            await DisplayAlert("Success", $"Scene {title} saved!", "OK");
        }
    }
}
