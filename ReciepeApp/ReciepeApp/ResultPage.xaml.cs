using ReciepeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReciepeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultPage : ContentPage
	{
        public ResultViewModel vm { get; set; }

        public ResultPage(string img, string info)
        {

            vm = new ResultViewModel();
            vm.Img = img;
            vm.Info = info;
            BindingContext = vm;

            InitializeComponent();
        }

    }
}