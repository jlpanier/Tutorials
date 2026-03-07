using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Countries
{
    /// <summary>
    /// Gestion de l'interface : https://data.enseignementsup-recherche.gouv.fr
    /// </summary>
    internal class CountryHeader
    {
        public int total_count { get; set; }

        public List<Country>? results { get; set; }
    }
}
