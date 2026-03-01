using CommunityToolkit.Mvvm.ComponentModel;
using DevExpress.Maui.Mvvm;

namespace Tutorials.ViewModels
{
    public partial class IndicatorViewModel : ObservableObject
    {
        public IList<MonkeyViewModel> Monkeys { get; private set; }

        public IndicatorViewModel()
        {
            Monkeys = new List<MonkeyViewModel>();
            Business.Monkeys.All().ForEach(m => Monkeys.Add(new MonkeyViewModel(m)));
        }
    }

}
