using System.Windows.Input;

namespace Tutorials.Pages;

public partial class GalleryPage : ContentPage
{
    public ICommand NavigateCommand { get; private set; }

    public GalleryPage()
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
