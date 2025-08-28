using System.Windows.Input;

namespace Maui.Tutorials.Pages;

public partial class TableViewMenuDemoPage : ContentPage
{
    public TableViewMenuDemoPage()
    {
        InitializeComponent();

        NavigateCommand = new Command<Type>(
            async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

        BindingContext = this;
    }

    public ICommand NavigateCommand { private set; get; }
}