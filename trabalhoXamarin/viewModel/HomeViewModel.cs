using System.Collections.Generic;
using System.Collections.ObjectModel;
using trabalhoXamarin.model;
using Xamarin.Forms;

namespace trabalhoXamarin.viewModel
{
    public sealed class HomeViewModel : BindableObject
    {
        private ObservableCollection<Candy> itens = new ObservableCollection<Candy>();

        public ObservableCollection<Candy> Items
        {
            get => itens;
            set { itens = value; OnPropertyChanged(); }
        }

        public HomeViewModel()
        {
            Items = new ObservableCollection<Candy>(
                new List<Candy>
                {
                    new Candy {Name = "WW", description = "teste"}
                }
            );
        }
    }
}
