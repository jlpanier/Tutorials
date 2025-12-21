using Tutorials.ViewModels;

namespace Tutorials.Pages
{
    public partial class UnicodePage : ContentPage
    {
        public UnicodePage()
        {
            InitializeComponent();
            BindingContext = new UnicodeViewModel();
            AppShell.SetNavBarIsVisible(this, false);
        }
        public UnicodePage(UnicodeViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            AppShell.SetNavBarIsVisible(this, false);
        }
    }
}

