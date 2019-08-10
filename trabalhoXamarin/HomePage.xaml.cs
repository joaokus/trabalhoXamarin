using trabalhoXamarin.viewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trabalhoXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var vm = new HomeViewModel();

            BindingContext = vm;
        }
    }
}