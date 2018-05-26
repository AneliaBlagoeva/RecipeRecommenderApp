using ReciepeApp.DataAccess;
using ReciepeApp.Droid;
using ReciepeApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                await DisplayAlert((Task.FromResult<Meal>(res)).Result.Name, (Task.FromResult<Meal>(res)).Result.Ingredients, "OK");
            }
        }
    }
}
