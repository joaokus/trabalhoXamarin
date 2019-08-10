using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoXamarin.viewModel;
using Xamarin.Forms;

namespace trabalhoXamarin
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var vm = new MainViewModel();
            BindingContext = vm;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}
