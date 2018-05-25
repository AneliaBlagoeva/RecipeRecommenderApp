using ReciepeApp.DataAccess;
using ReciepeApp.ViewModels;
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
            await DisplayAlert("Your reciepe", (Task.FromResult<Meal>(res)).Result.Ingredients, "OK");
        }
    }
}
