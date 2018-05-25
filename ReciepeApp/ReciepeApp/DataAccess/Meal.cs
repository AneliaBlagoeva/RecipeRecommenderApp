using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReciepeApp.DataAccess
{
    public class Meal
    {
        [PrimaryKey]
        public int IdMeal { get; set; }
        public int IdCategory { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public string Calories { get; set; }
        public string PrepTime { get; set; }
        public string MealImage { get; set; }
        public string Name { get; set; }
    }
}
