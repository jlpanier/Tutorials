using Tutorials.Models;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class CollectionViewDemoPage : ContentPage
{

    public CollectionViewDemoPage()
    {
        InitializeComponent();
        BindingContext = new CollectionViewModel();
    }
}
