using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ViewModels;

namespace ReciepeClient
{
    public partial class MainPage : ContentPage
	{
        public Request RequestObj { get; set; } = new Request();
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = RequestObj;

        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async void OnPasswordCompleted(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async Task LoginAsync()
        {
            //StudentInfo studentInfo = await LoginViewModel.GetStudentInfoAsync();
            //if (studentInfo != null)
            //{
              //  LoginViewModel.Password = String.Empty;
              //
              //  await grid.FadeTo(0, 500);
              // await Navigation.PushAsync(new CertificateOptionsPage(studentInfo), false);
              // grid.Opacity = 1;
            //}
            //else
           // {

                await DisplayAlert("Text",RequestObj.MealType,"Cancel");
            //}
        }
    }
}

