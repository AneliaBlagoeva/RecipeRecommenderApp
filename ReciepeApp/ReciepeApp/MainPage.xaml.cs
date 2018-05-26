using ReciepeApp.DataAccess;
using ReciepeApp.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReciepeApp
{
    public partial class MainPage : ContentPage
	{
        ItemsViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = viewModel = new ItemsViewModel();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            
            var res = await viewModel.FindMeal();
            if (res.Ingredients == "")
            {
                await DisplayAlert("Your reciepe", "Just go to the shop!", "OK");
            }
            else
            {
                string img = (Task.FromResult<Meal>(res)).Result.MealImage;
                string info = (Task.FromResult<Meal>(res)).Result.Name + (Task.FromResult<Meal>(res)).Result.Ingredients
                    + (Task.FromResult<Meal>(res)).Result.Steps + (Task.FromResult<Meal>(res)).Result.PrepTime;

                await Navigation.PushAsync(new ResultPage(img, info), false);
                    //DisplayAlert((Task.FromResult<Meal>(res)).Result.Name, (Task.FromResult<Meal>(res)).Result.Ingredients, "OK");
            }
        }
    }
}
