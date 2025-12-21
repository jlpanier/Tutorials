using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class ColorsPage : ContentPage
{
    public ColorsPage()
    {
        InitializeComponent();
        BindingContext = new ColorsViewModel();
    }
}
