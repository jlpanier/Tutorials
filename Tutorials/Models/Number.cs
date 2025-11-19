namespace Maui.Tutorials.Models
{
    public class Number
    {
        public bool IsPrimeNumber { get; private set; }

        public bool IsNotPrimeNumber => !IsPrimeNumber;

        public int Value { get; private set; }

        public int Somme { get; private set; }

        public string TextColor => IsPrimeNumber ? "Red" : "Black";

        public Number(int number, bool iSPrimeNumber, int somme)
        {
            IsPrimeNumber = iSPrimeNumber;
            Value = number;
            Somme = somme;
        }
    }
}
