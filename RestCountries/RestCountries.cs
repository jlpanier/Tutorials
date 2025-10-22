using System.Text.Json;

namespace RestCountries
{
    /// <summary>
    /// Gestion de l'interface : https://restcountries.com/v3.1/independent?status=true&fields=languages,capital,area,cioc,population
    /// </summary>
    public class RestCountries
    {
        public const string BaseUrl = "https://restcountries.com/v3.1/independent?status=true&fields=languages,capital,area,cca3,population";

        public static async Task<List<RestCountriesData>> Get()
        {
            var result = new List<RestCountriesData>();
            var items = await Call();
            if (items != null && items.Any())
            {
                result.AddRange(items);
            }

            return result;
        }

        private static async Task<List<RestCountriesData>>? Call()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(BaseUrl);

                    response.EnsureSuccessStatusCode(); // Throws exception if the status code is not 2xx

                    var answer = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<RestCountriesData>>(answer);
                }
            }
            catch (ArgumentNullException)
            {
                return new List<RestCountriesData>();
            }
            catch (JsonException e)
            {
                return new List<RestCountriesData>();
            }
            catch (NotSupportedException)
            {
                return new List<RestCountriesData>();
            }
        }
    }
}
