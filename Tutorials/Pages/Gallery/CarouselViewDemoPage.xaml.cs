using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class CarouselViewDemoPage : ContentPage
{
    

    public CarouselViewDemoPage()
    {
        InitializeComponent();
        BindingContext = new CarouselViewModel();
    }
}
