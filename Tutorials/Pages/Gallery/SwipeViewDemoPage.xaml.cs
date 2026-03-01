using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.Maui.Mvvm;
using Tutorials.ViewModels;

namespace Tutorials.Pages;

public partial class SwipeViewDemoPage : ContentPage
{
    public ObservableCollection<MonkeyViewModel> Monkeys { get; private set; }
    public ICommand DeleteCommand => new Command<MonkeyViewModel>(RemoveMonkey);

    public SwipeViewDemoPage()
    {
        InitializeComponent();
        Monkeys = new ObservableCollection<MonkeyViewModel>();
        Business.Monkeys.All().ForEach(m => Monkeys.Add(new MonkeyViewModel(m)));
        BindingContext = this;
    }

    void RemoveMonkey(MonkeyViewModel monkey)
    {
        if (Monkeys.Contains(monkey))
        {
            Monkeys.Remove(monkey);
        }
    }

}