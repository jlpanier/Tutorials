using Repository.Entities;
using SQLite;


namespace Repository.Dbo
{
    public abstract class BaseDbo:IDisposable
    {
        protected static readonly object dbLock = new object();

        private readonly string _dbPath;

        private SQLiteConnection? _db = null;

        public BaseDbo(string dbpath)
        {
            _dbPath = dbpath;
            Init();
        }

        public SQLiteConnection Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new SQLiteConnection(_dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.FullMutex, false);
                }
                return _db;
            }
        }

        /// <summary>
        /// Initialisation
        /// </summary>
        /// <param name="databasePath"></param>
        /// <param name="busyTimeout"></param>
        private void Init(double busyTimeout = 30)
        {
            Db.BusyTimeout = TimeSpan.FromSeconds(busyTimeout);
            Db.CreateTable(typeof(PrimeNumberEntity));
        }

        /// <summary>
        /// Is this instance disposed?
        /// </summary>
        protected bool Disposed { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            Close();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose worker method. See http://coding.abel.nu/2012/01/disposable
        /// </summary>
        /// <param name="disposing">Are we disposing? 
        /// Otherwise we're finalizing.</param>
        protected virtual void Dispose(bool disposing)
        {
            Disposed = true;
        }

        public void Close()
        {
            if (_db != null)
            {
                _db.Close();
                _db = null;
            }
        }

        public void Save(BaseEntity entity)
        {
            Db.InsertOrReplace(entity);
        }

        public void Save(IEnumerable<BaseEntity> entities)
        {
            lock (dbLock)
            {
                Db.RunInTransaction(() =>
                {
                    foreach (var e in entities)
                    {
                        e.Save(Db);
                    }
                });
            }
        }

        public void Remove(params BaseEntity[] entities)
        {
            Remove((IEnumerable<BaseEntity>)entities);
        }

        public void Remove(IEnumerable<BaseEntity> entities)
        {
            lock (dbLock)
            {
                Db.RunInTransaction(() =>
                {
                    foreach (var e in entities)
                    {
                        e.Remove(Db);
                    }
                });
            }
        }

        public int AddColumn(string tableName, string columnName, string type, string lenght)
        {
            lock (dbLock)
            {
                try
                {
                    return Db.Execute($"alter table {tableName} add column {columnName} {type} ({lenght})");
                }
                catch
                {
                    // Nothing
                }
                return -1;
            }
        }

        public int AddColumn(string tableName, string columnName, string type)
        {
            lock (dbLock)
            {
                try
                {
                    return Db.Execute($"alter table {tableName} add column {columnName} {type}");
                }
                catch
                {
                    // Nothing
                }
                return -1;
            }
        }

        public T ExecuteScalar<T>(string query, params object[] args)
        {
            lock (Db)
            {
                return Db.ExecuteScalar<T>(query, args);
            }
        }

        public int Execute(string query, params object[] args)
        {
            lock (Db)
            {
                return Db.Execute(query, args);
            }
        }

        public int Insert(object obj)
        {
            lock (Db)
            {
                return Db.Insert(obj);
            }
        }

        public int Update(object obj)
        {
            lock (Db)
            {
                return Db.Update(obj);
            }
        }

        public int Delete(object objectToDelete)
        {
            lock (Db)
            {
                return Db.Delete(objectToDelete);
            }
        }

        public int Delete<T>(object primaryKey)
        {
            lock (Db)
            {
                return Db.Delete<T>(primaryKey);
            }
        }

        public int DeleteAll<T>()
        {
            lock (Db)
            {
                return Db.DeleteAll<T>();
            }
        }

        public void CreateTable<T>() where T : class
        {
            lock (Db)
            {
                Db.CreateTable<T>();
            }
        }

        public void DropTable<T>() where T : class
        {
            lock (Db)
            {
                Db.DropTable<T>();
            }
        }

    }

}
