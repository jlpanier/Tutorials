using CommunityToolkit.Mvvm.ComponentModel;
using DevExpress.Maui.Mvvm;

namespace Tutorials.ViewModels
{
    public partial class CollectionViewModel : ObservableObject
    {
        public IList<MonkeyViewModel> Monkeys { get; private set; }

        public CollectionViewModel()
        {
            Monkeys = new List<MonkeyViewModel>();
            Business.Monkeys.All().ForEach(m => Monkeys.Add(new MonkeyViewModel(m)));
        }
    }
}
