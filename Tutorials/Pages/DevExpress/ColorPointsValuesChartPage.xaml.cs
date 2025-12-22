namespace Tutorials.Pages;

public partial class ColorPointsValuesChartPage : ContentPage
{
	public ColorPointsValuesChartPage()
	{
		InitializeComponent();
	}
    async void OnOpenWebButtonClicked(System.Object sender, System.EventArgs e)
    {
        await Browser.OpenAsync("https://www.devexpress.com/maui/");
    }
}