namespace Tutorials.Pages.Animations;

/// <summary>
/// Modification de la couleur de fond de la page avec une animation personnalisée
/// </summary>
public partial class CustomAnimationPage : ContentPage
{
	public CustomAnimationPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Evènement déclenché lors du clic sur le bouton "Change Color". Change la couleur de fond de la page avec une animation personnalisée.   
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnClickedAsync(object sender, EventArgs e)
    {

        Color bgColor = this.BackgroundColor;

        // Task.WhenAll is a combinator that lets you run multiple asynchronous operations in parallel and continue only when all of them have completed.
        await Task.WhenAll(
          this.ColorTo(bgColor, GetRandomColour(), c => this.BackgroundColor = c, 2000)
        );
    }

    /// <summary>
    /// Coefficient de changement
    /// </summary>
    private static readonly Random rand = new Random();

    /// <summary>
    /// Calcul de la couleur finale
    /// </summary>
    private Color GetRandomColour()
    {
        return Color.FromRgb(rand.Next(256), rand.Next(256), rand.Next(256));
    }
}