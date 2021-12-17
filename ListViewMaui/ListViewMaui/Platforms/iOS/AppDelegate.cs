using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ListViewMaui
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}