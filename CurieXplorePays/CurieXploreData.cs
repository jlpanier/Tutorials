using System.Text.Json;

namespace CurieXplorePays
{
    /// <summary>
    /// Gestion de l'interface : https://data.enseignementsup-recherche.gouv.fr
    /// </summary>
    public class CurieXploreData
    {
        // Détail des enregistrements fourni par l'appel API /data.enseignementsup-recherche.gouv.fr/explore/dataset/curiexplore-pays

        /// <summary>
        /// Code iso2 du pays/territoire
        /// </summary>
        public string iso2 {get; set; }

        /// <summary>
        /// Code iso du pays/territoire 
        /// </summary>
        public string iso3 {get; set; }

        /// <summary>
        /// Nom du pays en anglais 
        /// </summary>
        public string name_en {get; set; }

        /// <summary>
        /// Nom du pays en français
        /// </summary>
        public string name_fr {get; set; }

        /// <summary>
        /// Nom du pays en langue native
        /// </summary>
        public string name_native {get; set; }

        /// <summary>
        /// Code iso des pays frontaliers 
        /// </summary>
        public string borders {get; set; }

        /// <summary>
        /// Lien vers le drapeau format.svg 
        /// </summary>
        public string flag {get; set; }

        /// <summary>
        /// Lien vers la fiche mobilité de Campus France 
        /// </summary>
        public string cf_mobility {get; set; }

        /// <summary>
        /// Coordonnées géographiques du pays/territoire
        /// </summary>
        public LatLng latlng {get; set; }

        /// <summary>
        /// Identifiant wikidata
        /// </summary>
        public string wikidata {get; set; }

        /// <summary>
        /// Appartient au processus de Bologne.
        /// </summary>
        public string bologne {get; set; }

        /// <summary>
        /// Présence d’une ambassade dans le pays/territoire
        /// </summary>
        public string embassy {get; set; }

        /// <summary>
        /// Appartient au monde arabe
        /// </summary>
        public string arab_world {get; set; }

        /// <summary>
        /// Se situe en Europe centrale et les Balkans
        /// </summary>
        public string central_europe_and_the_baltics {get; set; }

        /// <summary>
        /// Se situe en Asie du Sud Est Pacifique
        /// </summary>
        public string east_asia_pacific {get; set; }

        /// <summary>
        /// Fait partie de la zone euro
        /// </summary>
        public string euro_area {get; set; }

        /// <summary>
        /// Se situe en Europe et Asie Centrale
        /// </summary>
        public string europe_central_asia {get; set; }

        /// <summary>
        /// Fait partie de l’Union Européenne
        /// </summary>
        public string european_union {get; set; }

        /// <summary>
        /// Pays/territoire à revenu élevé
        /// </summary>
        public string high_income {get; set; }

        /// <summary>
        /// Pays/territoire à faible revenu
        /// </summary>
        public string low_income {get; set; }

        /// <summary>
        /// Pays/territoire à revenu moyen faible
        /// </summary>
        public string lower_middle_income {get; set; }

        /// <summary>
        /// Se situe en Amérique Centrale et Caraïbes
        /// </summary>
        public string latin_america_carribean {get; set; }

        /// <summary>
        /// Se situe au Moyen-Orient et en Afrique du Nord
        /// </summary>
        public string middle_east_north_africa {get; set; }

        /// <summary>
        /// Se situe en Amérique du Nord
        /// </summary>
        public string north_america {get; set; }

        /// <summary>
        /// Pays membre de l’OCDE
        /// </summary>
        public string oecd_members {get; set; }

        /// <summary>
        /// Se situe en Afrique sub-saharienne
        /// </summary>
        public string sub_saharan_africa {get; set; }

        /// <summary>
        /// Pays/territoire à revenir moyen élevé
        /// </summary>
        public string upper_middle_income {get; set; }

        /// <summary>
        /// Lien vers les contacts des ambassades du pays/territoire
        /// </summary>
        public string link {get; set; }

        /// <summary>
        /// Lien vers le site de l’ambassade du pays/territoire
        /// </summary>
        public string website {get; set; }

        /// <summary>
        /// True s’il existe une fiche CurieXplore
        /// </summary>
        public string curiexplore {get; set; }

        /// <summary>
        /// Identifiant paysage de la catégorie géographique
        /// </summary>
        public string idpaysage {get; set; }

        /// <summary>
        /// Niveau d’indice de développement humain
        /// </summary>
        public string idh_group {get; set; }

        /// <summary>
        /// Code iso des pays à l’indice de développement humain proches
        /// </summary>
        public string idh_group_countries {get; set; }

        /// <summary>
        /// True si membre de l’Europe des Vingt-Sept
        /// </summary>
        public string ue27 {get; set; }

        /// <summary>
        /// Vaut True si membre du groupe des 7
        /// </summary>
        public string g7 {get; set; }

        /// <summary>
        /// Vaut True si membre du groupe de 19
        /// </summary>
        public string g20 {get; set; }

        /// <summary>
        /// GeoJSON du territoire
        /// </summary>
        //public string geometry {get; set; }
    }
}
