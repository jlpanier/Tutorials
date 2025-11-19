using Repository.Dbo;
using Repository.Entities;
using System.Collections.ObjectModel;

namespace Maui.Tutorials.Models
{
    public class PrimeNumbers
    {
        private string _databasePath;
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

        public void Init(string databasepath)
        {
            _databasePath = $"{databasepath}/PRIMENUMBER.sqlite";
        }

        public List<Number> Get()
        {
            Primes = new List<Number>();
            using (var dbo = new PrimeNumberDbo(_databasePath))
            {
                var items = dbo.Get();
                if (items.Any())
                {
                    int index = 1;
                    int somme = 0;
                    foreach (var prime in items.OrderBy(_ => _.Number))
                    {
                        while (index < prime.Number)
                        {
                            Primes.Add(new Number(index, false, somme));
                            index++;
                        }
                        Primes.Add(new Number(prime.Number, true, somme++));
                        index++;
                    }
                }
                else
                {
                    var defaultvalue = new PrimeNumbers();
                    foreach (var prime in defaultvalue.Primes.Where(_ => _.IsPrimeNumber).OrderBy(_ => _.Value))
                    {
                        dbo.Save(new PrimeNumberEntity()
                        {
                            Number = prime.Value,
                            DateMaj = DateTime.Now,
                        });
                        Primes.Add(prime);
                    }
                }
            }
            return Primes;
        }

        public Number Next()
        {
            Number? result = null;
            var lastvalue = Primes.Last();
            int number = lastvalue.Value + 1;
            int somme = lastvalue.Somme;
            var found = false;
            while (!found)
            {
                var isPrimeNumber = IsPrimeNumber(number);
                if (isPrimeNumber)
                {
                    found = true;
                    somme++;
                    using (var dbo = new PrimeNumberDbo(_databasePath))
                    {
                        dbo.Save(new PrimeNumberEntity()
                        {
                            Number = number,
                            DateMaj = DateTime.Now,
                        });
                    }
                    result = new Number(number, true, somme);
                }
                var item = new Number(number, isPrimeNumber, somme);
                Primes.Add(item);
                number++;
            }
            return result ?? new Number(1,true,1);
        }

        public List<Number> Primes { get; private set; }

        private PrimeNumbers()
        {
            _databasePath = string.Empty;
            Primes =new List<Number>()
            {
                new Number(1,true,1),
                new Number(2,true,2),
                new Number(3,true,3),
                new Number(4,false,3),
                new Number(5,true,4),
                new Number(6,false,4),
                new Number(7,true,5),
            };
        }

        private bool IsPrimeNumber(int number)
        {
            bool isPrimeNumber = number % 2 != 0;
            if (isPrimeNumber)
            {
                double racine = Math.Sqrt((double)number);
                int index = 0;
                var items = Primes.Where(_ => _.IsPrimeNumber && _.Value > 2 && _.Value <= racine).ToArray();
                while (index < items.Count() && isPrimeNumber)
                {
                    if (number % items[index].Value == 0)
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
