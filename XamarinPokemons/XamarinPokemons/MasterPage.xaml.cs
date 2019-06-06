using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Database;
using XamarinPokemons.Database.DbRepositories;
using XamarinPokemons.Models;
using XamarinPokemons.View.PokemonPages;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons
{
    [DesignTimeVisible(true)]
    public partial class MasterPage : ContentPage
    {
        public PokemonsViewModel pokemonsViewModel;
        public MasterPage()
        {
            InitializeComponent();

            //App.PokemonRepo.AddPokemon(new Pokemon
            //{
            //    PokemonName = "Pikachu", Name = "Pika", Height = 30, Weight = 12,
            //    ImageSource = ImageSource.FromFile("Pikachu.png")
            //});

            pokemonsViewModel = new PokemonsViewModel();
            pokemonsViewModel.Pokemons = new ObservableCollection<Pokemon>() { new Pokemon {PokemonName = "Pikachu",Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png")},
                new Pokemon { PokemonName = "Charizard",Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png"},
                new Pokemon { PokemonName = "Squirtle",Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png")}};

           // pokemonsViewModel.Pokemons = new ObservableCollection<Pokemon>(App.PokemonRepo.GetPokemons());

            var orderedViewModel = pokemonsViewModel.Pokemons.OrderBy(pokemon => pokemon.Name);

            listDetail.ItemsSource = orderedViewModel;

            L.Source = ImageSource.FromFile("Pokeball.png");
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemon = e.Item as Pokemon;

            pokemonsViewModel.SelectedPokemon = pokemon;

            //Detail = new NavigationPage(new PokemonPage(pokemonViewModel))
            //{
            //    BarBackgroundColor = Color.DeepSkyBlue
            //};
        }


    }
}