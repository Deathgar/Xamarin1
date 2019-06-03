using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.View.PokemonPages;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons
{
    [DesignTimeVisible(true)]
    public partial class MasterPage : MasterDetailPage
    {
        public PokemonsViewModel pokemonsViewModel;
        public MasterPage()
        {
            InitializeComponent();

            pokemonsViewModel = new PokemonsViewModel();

            var PersonalFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            pokemonsViewModel.Pokemons = new ObservableCollection<PokemonViewModel>() { new PokemonViewModel {PokemonName = "Pikachu",Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png")},
                new PokemonViewModel { PokemonName = "Charizard",Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png"},
                new PokemonViewModel { PokemonName = "Squirtle",Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png")}};



            Detail = new NavigationPage(new View1())
            {
                BarBackgroundColor = Color.DeepSkyBlue
            };

            pokemonsViewModel.Navigation = Navigation;

            var orderedViewModel = pokemonsViewModel.Pokemons.OrderBy(pokemon => pokemon.Name);

            listDetail.ItemsSource = orderedViewModel;

            L.Source = ImageSource.FromFile("Pokeball.png");
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemonViewModel = e.Item as PokemonViewModel;

            pokemonsViewModel.SelectedPokemon = pokemonViewModel;
            //Detail = new DetailNavigationPage(new PokemonPage(pokemonViewModel))
            //{
            //    BarBackgroundColor = Color.DeepSkyBlue
            //};
            IsPresented = false;
        }
    }
}