using Tutorials.ViewModels;

namespace Tutorials.Pages
{
    public partial class CultureInfoPage : ContentPage
    {
        public CultureInfoPage()
        {
            InitializeComponent();
            BindingContext = new CultureInfoViewModel();
            AppShell.SetNavBarIsVisible(this, false);
        }

        public CultureInfoPage(CultureInfoViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            AppShell.SetNavBarIsVisible(this, false);
        }
    }
}

