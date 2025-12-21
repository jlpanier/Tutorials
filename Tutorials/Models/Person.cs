using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, DateTime birthday, Color favoriteColor)
        {
            Name = name;
            Birthday = birthday;
            FavoriteColor = favoriteColor;
        }

        public string Name { set; get; }

        public DateTime Birthday { set; get; }

        public Color FavoriteColor { set; get; }
    }
}
