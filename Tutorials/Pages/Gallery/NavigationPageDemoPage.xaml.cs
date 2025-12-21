using System.Reflection;

namespace Tutorials.Pages;

public partial class NavigationPageDemoPage : ContentPage
{
	public NavigationPageDemoPage()
	{
		InitializeComponent();
	}
    async void OnButtonClicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string id = btn.StyleId;

        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Type pageType = assembly.GetType("Maui.Tutorials.Pages." + id);
        Page page = (Page)Activator.CreateInstance(pageType);
        await Navigation.PushAsync(page);
    }
}