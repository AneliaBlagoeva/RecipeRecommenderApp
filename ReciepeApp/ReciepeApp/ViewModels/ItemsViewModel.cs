using ReciepeApp.DataAccess;
using System.Threading.Tasks;

namespace ReciepeApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {

        public ItemsViewModel()
        {

        }

        public async Task<Meal> FindMeal()
        {
            return  await DbContext.FindFavouriteAsync(MealType, KeyOne, KeyTwo, KeyThree);
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
