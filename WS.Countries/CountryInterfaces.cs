using System.Text.Json;

namespace WS.Countries
{
    /// <summary>
    /// Gestion de l'interface : https://data.enseignementsup-recherche.gouv.fr
    /// </summary>
    public class CountryInterfaces
    {
        // https://data.enseignementsup-recherche.gouv.fr/explore/dataset/curiexplore-pays/api/?disjunctive.iso3

        public const string BaseUrl = "https://data.enseignementsup-recherche.gouv.fr/explore/dataset/curiexplore-pays";

        public const string HighIncomeUrl = "https://data.enseignementsup-recherche.gouv.fr/api/explore/v2.1/catalog/datasets/curiexplore-pays/records?limit=80&refine=high_income%3A%22True%22";

        public const string UpperMiddleIncomeUrl = "https://data.enseignementsup-recherche.gouv.fr/api/explore/v2.1/catalog/datasets/curiexplore-pays/records?limit=80&refine=upper_middle_income%3A%22True%22";

        public const string LowMiddleIncomeUrl = "https://data.enseignementsup-recherche.gouv.fr/api/explore/v2.1/catalog/datasets/curiexplore-pays/records?limit=80&refine=lower_middle_income%3A%22True%22";

        public const string LowIncomeUrl = "https://data.enseignementsup-recherche.gouv.fr/api/explore/v2.1/catalog/datasets/curiexplore-pays/records?limit=80&refine=low_income%3A%22True%22";

        public static async Task<List<Country>> Get()
        {
            var result = new List<Country>();

            var items = await Get(LowIncomeUrl);
            result.AddRange(items);

            items = await Get(LowMiddleIncomeUrl);
            result.AddRange(items);

            items = await Get(UpperMiddleIncomeUrl);
            result.AddRange(items);

            items = await Get(HighIncomeUrl);
            result.AddRange(items);

            return result;
        }

        private static async Task<List<Country>> Get(string url)
        {
            var result = new List<Country>();
            var items = await Call(url);
            if (items != null && items.results!.Any())
            {
                result.AddRange(items.results!);
            }
            return result;
        }

        private static async Task<CountryHeader?> Call(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    response.EnsureSuccessStatusCode(); // Throws exception if the status code is not 2xx

                    var answer = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<CountryHeader>(answer);
                }
            }
            catch (ArgumentNullException)
            {
                return new CountryHeader();
            }
            catch (JsonException)
            {
                return new CountryHeader();
            }
            catch (NotSupportedException)
            {
                return new CountryHeader();
            }
        }
    }
}
