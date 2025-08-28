using Maui.Tutorials.ViewModels;

namespace Maui.Tutorials.Pages
{
    public partial class FirstMauiPage : ContentPage
    {
        public FirstMauiPage()
        {
            InitializeComponent();
            BindingContext = new FirstMauiViewModel();
        }

        public FirstMauiPage(FirstMauiViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}



