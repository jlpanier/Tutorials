namespace RestCountries
{
    /// <summary>
    /// Gestion de l'interface : https://restcountries.com/v3.1/independent?status=true&fields=languages,capital,area,cioc,population
    /// </summary>
    public class RestCountriesResult
    {
        // Détail des enregistrements fourni par l'appel API https://restcountries.com/v3.1

        public List<RestCountriesData> Data { get; set; }
    }
}
