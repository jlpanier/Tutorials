using Tutorials.ViewModels.Animations;

namespace Tutorials.Pages.Animations;

public partial class AnimationsPage : ContentPage
{
	public AnimationsPage()
	{
		InitializeComponent();
        BindingContext = new AnimationsViewModel();
    }
}