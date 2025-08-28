using System.Windows.Input;

namespace Maui.Tutorials.Pages
{
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
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
}