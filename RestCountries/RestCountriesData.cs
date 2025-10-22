namespace RestCountries
{
    /// <summary>
    /// Gestion de l'interface : https://restcountries.com/v3.1/independent?status=true&fields=languages,capital,area,cioc,population
    /// </summary>
    public class RestCountriesData
    {
        // Détail des enregistrements fourni par l'appel API https://restcountries.com/v3.1

        /// <summary>
        /// Code iso2 du pays/territoire
        /// </summary>
        public string cca3 { get; set; }

        /// <summary>
        /// Capital
        /// </summary>
        public List<string> capital { get; set; }

        /// <summary>
        /// area
        /// </summary>
        public double area { get; set; }

        /// <summary>
        /// population
        /// </summary>
        public int population { get; set; }
    }
}
