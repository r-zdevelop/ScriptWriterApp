using Microsoft.Maui.Controls;
using ScriptWriterApp.Models;

namespace ScriptWriterApp.Views
{
    public partial class StageForm : ContentPage
    {
        public StageForm()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            string description = StageDescriptionEditor.Text;

            if (string.IsNullOrWhiteSpace(description))
            {
                await DisplayAlert("Error", "Stage description is required", "OK");
                return;
            }

            // Create new Stage object
            Stage newStage = new Stage
            {
                Description = description
            };

            // Save or pass the stage
            await DisplayAlert("Success", "Stage saved!", "OK");
        }
    }
}
