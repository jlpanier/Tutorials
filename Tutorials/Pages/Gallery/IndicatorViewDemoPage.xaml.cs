using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class IndicatorViewDemoPage : ContentPage
{

    public IndicatorViewDemoPage()
    {
        InitializeComponent();
        BindingContext = new IndicatorViewModel();
    }

}