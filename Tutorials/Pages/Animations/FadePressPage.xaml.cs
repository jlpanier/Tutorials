namespace Tutorials.Pages.Animations;

public partial class FadePressPage : ContentPage
{
	public FadePressPage()
	{
		InitializeComponent();
	}

    void Handle_Pressed(object sender, EventArgs e)
    {
        if (sender is VisualElement view)
        {
            view.FadeToAsync(0, 100);
        }        
    }

    void Handle_Released(object sender, EventArgs e)
    {
        if (sender is VisualElement view)
        {
            view.FadeToAsync(1, 200);
        }
    }
}