using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ScriptWriterApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		// Method to toggle bold formatting
		private void OnBoldClicked(object sender, EventArgs e)
		{
			// This is a simple toggle; real implementation would require rich text editor support
			ScriptEditor.FontAttributes ^= FontAttributes.Bold;
		}

		// Method to toggle italic formatting
		private void OnItalicClicked(object sender, EventArgs e)
		{
			// This is a simple toggle; real implementation would require rich text editor support
			ScriptEditor.FontAttributes ^= FontAttributes.Italic;
		}

		// Method to save the script to a local file
		private async void OnSaveClicked(object sender, EventArgs e)
		{
			string scriptContent = ScriptEditor.Text;
			string fileName = $"Script_{DateTime.Now:yyyyMMddHHmmss}.txt";

			string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

			try
			{
				Console.WriteLine($"Saving script to {filePath}");
				// Save the script text to a file
				await File.WriteAllTextAsync(filePath, scriptContent);
				await DisplayAlert("Success", $"Script saved as {fileName}", "OK");
			}
			catch (Exception ex)
			{
				await DisplayAlert("Error", $"Failed to save script: {ex.Message}", "OK");
			}
		}

		// Method to export the script as a PDF file
		private async void OnExportPdfClicked(object sender, EventArgs e)
		{
			string scriptContent = ScriptEditor.Text;
			string fileName = $"Script_{DateTime.Now:yyyyMMddHHmmss}.pdf";

			string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

			try
			{
				// Here you would use a PDF generation library to convert scriptContent to PDF
				// For this example, we're using plain text export. You'll need a PDF library like Syncfusion or iText7 for real PDF generation.

				File.WriteAllText(filePath, scriptContent); // Placeholder for PDF generation
				await DisplayAlert("Success", $"Script exported as {fileName}", "OK");
			}
			catch (Exception ex)
			{
				await DisplayAlert("Error", $"Failed to export script: {ex.Message}", "OK");
			}
		}
	}
}
