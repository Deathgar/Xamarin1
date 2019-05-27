using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Test3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : MasterDetailPage
    {
        public PokemonStorage storagePokemons;
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new View1())
            {
                BarBackgroundColor = Color.DeepSkyBlue
            };

            storagePokemons = new PokemonStorage();
            var k = storagePokemons.FillPokemons();
            k.OrderBy(x => x.Name);
            storagePokemons.pokemons = k;

            listDetail.ItemsSource = storagePokemons.pokemons;

            L.Source = ImageSource.FromFile("Pokeball.png");
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemon = e.Item as Pokemon;
            Detail = new NavigationPage(new PokemonPage( pokemon))
            {
                BarBackgroundColor = Color.DeepSkyBlue
            };
            IsPresented = false;
        }
    }
}
