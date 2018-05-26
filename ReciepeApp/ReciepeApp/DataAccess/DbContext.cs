using ReciepeApp.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Android.InputMethodServices.InputMethodService;

namespace ReciepeApp.DataAccess
{
    public class DbContext
    {

        public static async Task<Meal> FindFavouriteAsync(string mealType, string keyOne, string keyTwo, string keyThree)
        {
            SQLiteService neshto = new SQLiteService();

            //SQLiteConnection db = neshto.DbConnection();
            //db.CreateTable<Meal>();
            //var res = db.Execute(" SELECT ingredients FROM Meal");
            //var result = db.Find<Meal>(f => f.Ingredients.Contains(keyOne));

            Meal res = new Meal();
            XDocument xml = neshto.GetXML();
            foreach (XElement item in xml.Root.Elements("Table"))
            {

                var ingredients = item.Element("ingredients").Value;
                var type = item.Element("idCategory").Value;

                if (type == mealType)
                {
                    if(ingredients.Contains(keyOne) && ingredients.Contains(keyTwo) && ingredients.Contains(keyThree))
                    {
                        res = new Meal(item.Element("name").Value,
                           ingredients,
                            item.Element("steps").Value,
                            item.Element("calories").Value,
                            item.Element("prepTime").Value,
                            item.Element("mealImage").Value);
                        break;
                    }
                    else if (ingredients.Contains(keyOne) || ingredients.Contains(keyTwo) || ingredients.Contains(keyThree))
                    {
                        res = new Meal(item.Element("name").Value,
                           ingredients,
                            item.Element("steps").Value,
                            item.Element("calories").Value,
                            item.Element("prepTime").Value,
                            item.Element("mealImage").Value);
                        break;
                    }
                    else
                    {
                        res = new Meal();
                    }
                }
               
            }


            return res;
        
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
