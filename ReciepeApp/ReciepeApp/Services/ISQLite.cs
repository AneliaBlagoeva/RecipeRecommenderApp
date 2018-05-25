using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReciepeApp.Services
{
    interface ISQLite
    {
        SQLiteConnection DbConnection();
    }
}
