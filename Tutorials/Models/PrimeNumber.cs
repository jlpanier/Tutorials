namespace Maui.Tutorials.Models
{
    public class PrimeNumber
    {
        public bool IsPrimeNumber { get; private set; }

        public bool IsNotPrimeNumber => !IsPrimeNumber;

        public int Number { get; private set; }

        public int Somme { get; private set; }

        public PrimeNumber(int number, bool iSPrimeNumber, int somme)
        {
            IsPrimeNumber = iSPrimeNumber;
            Number = number;
            Somme = somme;
        }
    }
}
