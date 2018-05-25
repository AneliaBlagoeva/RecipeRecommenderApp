using ReciepeApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReciepeApp.ViewModels
{
    class ItemsViewModel : BaseViewModel
    {
       // public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            //item = new Item();
            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        public async Task<Meal> FindMeal()
        {
            Task<Meal> x = Task.Factory.StartNew(() => {
                var t = DbContext.FindFavouriteAsync(MealType, KeyOne, KeyTwo, KeyThree);
                return t;
            });

            return await x;
            //return  await DbContext.FindFavouriteAsync(MealType, KeyOne, KeyTwo, KeyThree);
        }

        private string mealType;
        private string keyOne;
        private string keyTwo;
        private string keyThree;

        public string MealType
        {
            get
            {
                return mealType;
            }
            set
            {
                mealType = value;
                OnPropertyChanged();
            }
        }

        public string KeyOne
        {
            get
            {
                return keyOne;
            }
            set
            {
                keyOne = value;
                OnPropertyChanged();
            }
        }

        public string KeyTwo
        {
            get
            {
                return keyTwo;
            }
            set
            {
                keyTwo = value;
                OnPropertyChanged();
            }
        }

        public string KeyThree
        {
            get
            {
                return keyThree;
            }
            set
            {
                keyThree = value;
                OnPropertyChanged();
            }
        }

    }
}
