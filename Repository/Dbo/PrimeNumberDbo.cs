using Repository.Entities;

namespace Repository.Dbo
{
    public class PrimeNumberDbo: BaseDbo
    {
        public PrimeNumberDbo(string dbpath) : base(dbpath)
        {
        }

        public IEnumerable<PrimeNumberEntity> Get()
        {
            lock (dbLock)
            {
                return Db.Query<PrimeNumberEntity>("Select * from PRIME_NUMBER");
            }
        }
    }
}
