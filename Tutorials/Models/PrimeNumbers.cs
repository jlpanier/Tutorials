namespace Maui.Tutorials.Models
{
    public class PrimeNumbers
    {
        public static PrimeNumbers Instance 
        { 
            get
            {
                if (_primeNumbers==null)
                {
                    _primeNumbers = new PrimeNumbers();
                }
                return _primeNumbers;
            }
        }
        private static PrimeNumbers? _primeNumbers;


        public List<PrimeNumber> Get(int size)
        {
            var item = Primes.Last();
            int number = item.Number + 1;
            int somme = item.Somme;
            while (number <= size)
            {
                var isPrimeNumber = IsPrimeNumber(number);
                if (isPrimeNumber) somme++;
                Primes.Add(new PrimeNumber(number, isPrimeNumber, somme));
                number++;
            }
            return Primes;
        }

        private List<PrimeNumber> Primes;

        private PrimeNumbers()
        {
            Primes=new List<PrimeNumber>()
            {
                new PrimeNumber(1,true,1),
                new PrimeNumber(2,true,2),
                new PrimeNumber(3,true,3),
                new PrimeNumber(4,false,3),
                new PrimeNumber(5,true,4),
                new PrimeNumber(6,false,4),
                new PrimeNumber(7,true,5),
            };
        }

        private bool IsPrimeNumber(int number)
        {
            bool isPrimeNumber = number % 2 != 0;
            if (isPrimeNumber)
            {
                double racine = Math.Sqrt((double)number);
                int index = 0;
                var items = Primes.Where(_ => _.IsPrimeNumber && _.Number > 2 && _.Number <= racine).ToArray();
                while (index < items.Count() && isPrimeNumber)
                {
                    if (number % items[index].Number == 0)
                    {
                        isPrimeNumber = false;
                    }
                    index++;
                }
            }
            return isPrimeNumber;
        }

    }
}
