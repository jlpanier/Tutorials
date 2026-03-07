
namespace Tutorials.Pages.Animations
{
    /// <summary>
    /// Extensions pour les vues
    /// </summary>
    public static class ViewExtensions
    {
        /// <summary>
        /// Changement progressive de la couleur de l'élément (cf. callback) de la vue
        /// </summary>
        /// <param name="self"></param>
        /// <param name="fromColor">couleur de début</param>
        /// <param name="toColor">Couleur finale</param>
        /// <param name="callback">Application du changement de couleur</param>
        /// <param name="length">Durée de l'animation</param>
        /// <param name="easing">Mode de progression du changement de couleur</param>
        /// <returns></returns>
        public static Task<bool> ColorTo(this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing? easing = null)
        {
            Func<double, Color> transform = (t) =>
                Color.FromRgba(fromColor.Red + t * (toColor.Red - fromColor.Red),
                               fromColor.Green + t * (toColor.Green - fromColor.Green),
                               fromColor.Blue + t * (toColor.Blue - fromColor.Blue),
                               fromColor.Alpha + t * (toColor.Alpha - fromColor.Alpha));
            return ColorAnimation(self, "ColorTo", transform, callback, length, easing);
        }

        public static void CancelAnimation(this VisualElement self)
        {
            self.AbortAnimation("ColorTo");
        }

        /// <summary>
        /// Application du changement de couleur
        /// </summary>
        /// <param name="element"></param>
        /// <param name="name"></param>
        /// <param name="transform"></param>
        /// <param name="callback"></param>
        /// <param name="length"></param>
        /// <param name="easing">Courbure du changement de couleur</param>
        /// <returns></returns>
        static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing? easing)
        {
            easing = easing ?? Easing.Linear;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            element.Animate<Color>(name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));
            return taskCompletionSource.Task;
        }
    }
}
