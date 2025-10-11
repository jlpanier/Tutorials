using System.Text.Json;

namespace CurieXplorePays
{
    /// <summary>
    /// Gestion de l'interface : https://data.enseignementsup-recherche.gouv.fr
    /// </summary>
    public class CurieXploreHeader
    {
        public int total_count { get; set; }

        public List<CurieXploreData> results { get; set; }
    }
}
