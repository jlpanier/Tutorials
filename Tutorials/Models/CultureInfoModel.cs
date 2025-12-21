using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    public class CultureInfoModel
    {
        public CultureInfo _cultureInfo { get; private set; }

        public string  Name => _cultureInfo.Name;

        public string DisplayName => _cultureInfo.DisplayName;

        public string Iso => _cultureInfo.TwoLetterISOLanguageName;

        public int Lcid => _cultureInfo.LCID;

        public CultureInfoModel(CultureInfo item) 
        {
            _cultureInfo = item;
        }
    }
}
