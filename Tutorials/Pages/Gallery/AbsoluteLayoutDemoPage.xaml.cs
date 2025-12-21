namespace Tutorials.Pages
{
    public partial class AbsoluteLayoutDemoPage : ContentPage
    {
        private Timer? timer;
        private DateTime beginTime = DateTime.Now;

        public AbsoluteLayoutDemoPage()
        {
            InitializeComponent();
        }

        ~AbsoluteLayoutDemoPage() => timer?.Dispose();

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DateTime beginTime = DateTime.Now;

            // Start immediately, repeat every 1 second
            timer = new Timer(Callback, null, TimeSpan.Zero, TimeSpan.FromSeconds(1.0 / 4));
        }

        private void Callback(Object? state)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                double seconds = (DateTime.Now - beginTime).TotalSeconds;
                double offset = 1 - Math.Abs((seconds % 2) - 1);

                AbsoluteLayout.SetLayoutBounds(text1,
                    new Rect(offset, offset,
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                AbsoluteLayout.SetLayoutBounds(text2,
                    new Rect(1 - offset, offset,
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            });        
        }

    }
}