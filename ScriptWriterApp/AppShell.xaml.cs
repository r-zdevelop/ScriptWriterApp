using Microsoft.Maui.Controls;

namespace ScriptWriterApp
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			// Register routes if necessary
			Routing.RegisterRoute("IntroPage", typeof(Views.IntroPage));
			Routing.RegisterRoute("MainPage", typeof(Views.MainPage));
		}
	}
}
