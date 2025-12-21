using CommunityToolkit.Mvvm.ComponentModel;
using Tutorials.Models;
using Syncfusion.Maui.DataSource.Extensions;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Tutorials.ViewModels
{
    public partial class CultureInfoViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<CultureInfoModel> items;

        public CultureInfoViewModel()
        {
            var dataset = new List<CultureInfoModel>();
            CultureInfo.GetCultures(CultureTypes.AllCultures).ForEach(_=>dataset.Add(new CultureInfoModel(_)));
            Items = new ObservableCollection<CultureInfoModel>(dataset);
        }
    }
}
