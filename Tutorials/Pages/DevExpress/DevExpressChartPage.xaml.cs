using System.Windows.Input;

namespace Tutorials.Pages;

public partial class DevExpressChartPage : ContentPage
{
    public ICommand NavigateCommand { get; private set; }

    public DevExpressChartPage()
	{
		InitializeComponent();

        NavigateCommand = new Command<Type>(async (Type pageType) =>
        {
            var objectPage = Activator.CreateInstance(pageType);
            if (objectPage is Page page)
            {
                await Navigation.PushAsync(page);
            }
        });

        BindingContext = this;
    }
}