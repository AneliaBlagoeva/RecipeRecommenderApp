using ReciepeApp.Services;
using SQLite;
using System.IO;

namespace ReciepeApp.Droid
{
    public class SQLiteService : ISQLite
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "Reciepe.db";
            var path = Path.Combine(System.Environment.
              GetFolderPath(System.Environment.
              SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }
    }
}