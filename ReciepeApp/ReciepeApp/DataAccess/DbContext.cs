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

        public static async Task<Meal> FindFavouriteAsync(string mealType, string keyOne, string keyTwo, string keyThree)
        {
            SQLiteService neshto = new SQLiteService();

            SQLiteConnection db = neshto.DbConnection();
            var result = await db.Find<Task<Meal>>(f => ((Task.FromResult<Meal>(f)).Result.Ingredients.Contains(keyOne))); ;
            return result;
        }
    }
}
