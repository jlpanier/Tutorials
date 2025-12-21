using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.ViewModels
{
    public partial class ColorsViewModel : ObservableObject
    {
        public ObservableCollection<ColorItem> ColorsList { get; } = new();

        public ColorsViewModel()
        {
            var fields = typeof(Colors).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in fields)
            {
                if (field.FieldType == typeof(Color))
                {
                    var color = (Color)field.GetValue(null);
                    ColorsList.Add(new ColorItem
                    {
                        Name = field.Name,
                        Value = color,
                        Hex = color.ToHex()
                    });
                }
            }

        }
    }

    public class ColorItem
    {
        public string Name { get; set; }
        public Color Value { get; set; }
        public string Hex { get; set; }
    }

}
