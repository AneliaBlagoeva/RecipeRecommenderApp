using ReciepeApp.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReciepeApp.DataAccess
{
    public class DbContext
    {

        public static  Meal FindFavouriteAsync(string mealType, string keyOne, string keyTwo, string keyThree)
        {
            SQLiteService neshto = new SQLiteService();

            SQLiteConnection db = neshto.DbConnection();
            var result =  db.Find<Meal>(f => f.Ingredients.Contains(keyOne));
            return result;
        }

        //public static async Task<Meal> FindFavouriteAsync(string mealType, string keyOne, string keyTwo, string keyThree)
        //{
        //    SQLiteService neshto = new SQLiteService();

        //    SQLiteConnection db = neshto.DbConnection();
        //    var result = await db.Find<Meal>(f => f.Ingredients.Contains(keyOne));
        //    return result;
        //}
    }
}
