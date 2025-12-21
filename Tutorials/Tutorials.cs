using Tutorials.Models;

namespace Tutorials
{
    public class Tutorials
    {
        public static Tutorials Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tutorials();
                }
                return _instance;
            }
        }
        public static Tutorials? _instance;

        private Tutorials()
        {
        }

        public void Init()
        {
            AppPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            DbPath = Path.Combine(AppPath, "db");
            ImagePath = Path.Combine(AppPath, "images");
            FilePath = Path.Combine(AppPath, "file");
            TmpPath = Path.Combine(AppPath, "tmp");
            MapPath = Path.Combine(AppPath, "maps");

            Directory.CreateDirectory(AppPath);
            Directory.CreateDirectory(DbPath);
            Directory.CreateDirectory(FilePath);
            Directory.CreateDirectory(TmpPath);
            Directory.CreateDirectory(ImagePath);
            Directory.CreateDirectory(MapPath);

            PrimeNumbers.Instance.Init(DbPath);
        }

        /// <summary>
        /// Répertoire interne de l'application
        /// </summary>
        public string AppPath { get; private set; } = "";

        /// <summary>
        /// Répertoire de stockage des cartes
        /// </summary>
        public string MapPath { get; private set; } = "";

        /// <summary>
        /// Chemin des images 
        /// </summary>
        public string ImagePath { get; private set; } = "";

        /// <summary>
        /// Chemin de la base de données
        /// </summary>
        public string DbPath { get; private set; } = "";

        /// <summary>
        /// Chemin complet de la base de données
        /// </summary>
        public string DbFilePath { get; private set; } = "";

        /// <summary>
        /// Chemin de partage des fichiers
        /// </summary>
        public string FilePath { get; private set; } = "";

        /// <summary>
        /// Chemin temporaire des fichiers
        /// </summary>
        public string TmpPath { get; private set; } = "";
    }
}
