using Common;
using CurieXplorePays;

namespace Maui.Tutorials.Models
{
    /// <summary>
    /// Gestion des pays
    /// </summary>
    public class Country
    {
        // https://data.enseignementsup-recherche.gouv.fr/explore/dataset/curiexplore-pays/api/?disjunctive.iso3
        // 

        // Détail des enregistrements fourni par l'appel API /data.enseignementsup-recherche.gouv.fr/explore/dataset/curiexplore-pays

        /// <summary>
        /// Code iso2 du pays/territoire
        /// </summary>
        public string Iso2 { get; private set; } = "";

        /// <summary>
        /// Code iso du pays/territoire 
        /// </summary>
        public string Iso3 { get; private set; } = "";

        /// <summary>
        /// Nom du pays en anglais 
        /// </summary>
        public string NameEN { get; private set; } = "";

        /// <summary>
        /// Nom du pays en français
        /// </summary>
        public string Name { get; private set; } = "";

        /// <summary>
        /// Nom du pays en langue native
        /// </summary>
        public string NativeName { get; private set; } = "";

        /// <summary>
        /// Code iso des pays frontaliers 
        /// </summary>
        public string Borders { get; private set; } = "";

        /// <summary>
        /// Lien vers le drapeau format.svg 
        /// </summary>
        public string Flag { get; private set; } = "";

        /// <summary>
        /// Lien vers la fiche mobilité de Campus France 
        /// </summary>
        public string Mobility { get; private set; } = "";

        /// <summary>
        /// Coordonnées géographiques du pays/territoire
        /// </summary>
        public Gps LatLng { get; private set; } = new Gps();

        /// <summary>
        /// Identifiant wikidata
        /// </summary>
        public string Wikidata { get; private set; } = "";

        /// <summary>
        /// Appartient au processus de Bologne.
        /// </summary>
        public bool Bologne { get; private set; } = false;

        /// <summary>
        /// Présence d’une ambassade dans le pays/territoire
        /// </summary>
        public bool Embassy { get; private set; } = false;

        /// <summary>
        /// Appartient au monde arabe
        /// </summary>
        public bool Arab { get; private set; } = false;

        /// <summary>
        /// Se situe en Europe centrale et les Balkans
        /// </summary>
        public bool CentralEurope { get; private set; } = false;

        /// <summary>
        /// Se situe en Asie du Sud Est Pacifique
        /// </summary>
        public bool EastAsia { get; private set; } = false;

        /// <summary>
        /// Fait partie de la zone euro
        /// </summary>
        public bool Euro { get; private set; } = false;

        /// <summary>
        /// Se situe en Europe et Asie Centrale
        /// </summary>
        public bool EuroAndAsiaCentral { get; private set; } = false;

        /// <summary>
        /// Fait partie de l’Union Européenne
        /// </summary>
        public bool EuropeUnion { get; private set; } = false;

        /// <summary>
        /// Pays/territoire à revenu élevé
        /// </summary>
        public bool HighIncome { get; private set; } = false;

        /// <summary>
        /// Pays/territoire à faible revenu
        /// </summary>
        public bool LowIncome { get; private set; } = false;

        /// <summary>
        /// Pays/territoire à revenu moyen faible
        /// </summary>
        public bool LowMiddleIncome { get; private set; } = false;

        /// <summary>
        /// Se situe en Amérique Centrale et Caraïbes
        /// </summary>
        public bool LatinAmericaCarribean { get; private set; } = false;

        /// <summary>
        /// Se situe au Moyen-Orient et en Afrique du Nord
        /// </summary>
        public bool MiddleEastNorthAfrica { get; private set; } = false;

        /// <summary>
        /// Se situe en Amérique du Nord
        /// </summary>
        public bool NorthAmerica { get; private set; } = false;

        /// <summary>
        /// Pays membre de l’OCDE
        /// </summary>
        public bool OecdMembers { get; private set; } = false;

        /// <summary>
        /// Se situe en Afrique sub-saharienne
        /// </summary>
        public bool sub_saharan_africa { get; private set; } = false;

        /// <summary>
        /// Pays/territoire à revenir moyen élevé
        /// </summary>
        public bool upper_middle_income { get; private set; } = false;

        /// <summary>
        /// Lien vers les contacts des ambassades du pays/territoire
        /// </summary>
        public string Link { get; private set; } = "";

        /// <summary>
        /// Lien vers le site de l’ambassade du pays/territoire
        /// </summary>
        public string Website { get; private set; } = "";

        /// <summary>
        /// True s’il existe une fiche CurieXplore
        /// </summary>
        public bool curiexplore { get; private set; } = false;

        /// <summary>
        /// Identifiant paysage de la catégorie géographique
        /// </summary>
        public string idpaysage { get; private set; } = "";

        /// <summary>
        /// Niveau d’indice de développement humain
        /// </summary>
        public string idh_group { get; private set; } = "";

        /// <summary>
        /// Code iso des pays à l’indice de développement humain proches
        /// </summary>
        public string idh_group_countries { get; private set; } = "";

        /// <summary>
        /// True si membre de l’Europe des Vingt-Sept
        /// </summary>
        public bool ue27 { get; private set; }

        /// <summary>
        /// Vaut True si membre du groupe des 7
        /// </summary>
        public bool G7 { get; private set; } = false;

        /// <summary>
        /// Vaut True si membre du groupe de 19
        /// </summary>
        public bool G20 { get; private set; } = false;

        public static async Task<List<Country>> Get()
        {
            var result = new List<Country>();
            var items = await CurieXplore.Get();
            items.ForEach(_=>result.Add(new Country(_)));
            return result;
        }

        public Country()
        {
        }

        public Country(CurieXploreData data)
        {
            Iso2 = data.iso2;
            Iso3 = data.iso3;
            NameEN = data.name_en;
            Name = data.name_fr;
            NativeName=data.name_native;
            Borders = data.borders;
            Flag = data.flag;
            Mobility = data.cf_mobility;
            LatLng = new Gps(data.latlng.lat, data.latlng.lon);
            Wikidata = data.wikidata;
            Bologne = data.bologne == "True";
            Embassy = data.embassy == "True";
            Arab = data.arab_world == "True";
            CentralEurope = data.central_europe_and_the_baltics == "True";
            EastAsia = data.east_asia_pacific == "True";
            Euro = data.euro_area == "True";
            EuroAndAsiaCentral = data.europe_central_asia == "True";
            EuropeUnion = data.european_union == "True";
            HighIncome = data.high_income == "True";
            LowIncome = data.low_income == "True";
            LowMiddleIncome = data.lower_middle_income == "True";
            LatinAmericaCarribean = data.latin_america_carribean == "True";
            MiddleEastNorthAfrica = data.middle_east_north_africa == "True";
            NorthAmerica = data.north_america == "True";
            OecdMembers = data.oecd_members == "True";
            sub_saharan_africa = data.sub_saharan_africa == "True";
            upper_middle_income = data.upper_middle_income == "True";
            Link = data.link;
            Website = data.website;
            curiexplore = data.curiexplore == "True";
            idpaysage = data.idpaysage;
            idh_group = data.idh_group;
            idh_group_countries = data.idh_group_countries;
            ue27 = data.ue27 == "True";
            G7 = data.G7 == "True";
            G20 = data.G20 == "True";
        }
    }
}
