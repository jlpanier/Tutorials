using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class GalleryPage : ContentPage
{
    public GalleryPage()
    {
        InitializeComponent();
        BindingContext = new GalleryViewModel();
    }
}
