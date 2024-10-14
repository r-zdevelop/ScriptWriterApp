using Microsoft.Maui.Controls;
using System;

namespace ScriptWriterApp.Views
{
	public partial class MainPage : ContentPage
	{
		private string scriptName;
		private string filePath;

		// Constructor accepting two parameters
		public MainPage(string scriptName, string filePath)
		{
			InitializeComponent();
			this.scriptName = scriptName;
			this.filePath = filePath;

			// You can set the title of the page based on the script name, for example
			Title = $"Editing: {scriptName}";

			// Optionally, handle any logic related to loading the script from the file path
			if (!string.IsNullOrEmpty(filePath))
			{
				LoadScript(filePath);
			}
		}

		// Example method to load the script if provided
		private void LoadScript(string filePath)
		{
			// Logic to load the script
		}
	}
}
