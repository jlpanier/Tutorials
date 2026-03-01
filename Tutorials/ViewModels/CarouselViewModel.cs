using CommunityToolkit.Mvvm.ComponentModel;
using DevExpress.Maui.Mvvm;

namespace Tutorials.ViewModels
{
    public partial class CarouselViewModel : ObservableObject
    {
        public IList<MonkeyViewModel> Monkeys { get; private set; }

        public CarouselViewModel()
        {
            Monkeys = new List<MonkeyViewModel>();
            Business.Monkeys.All().ForEach(m => Monkeys.Add(new MonkeyViewModel(m)));
        }
    }
}
