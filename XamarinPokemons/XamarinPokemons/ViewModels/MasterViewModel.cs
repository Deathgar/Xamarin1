using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.ViewModels
{
    class MasterViewModel
    {
        public PokemonPageViewModel pokemonPageViewModel { get; set; }

        public MasterViewModel()
        {
            var pokemonPageViewModel = new PokemonPageViewModel();

            pokemonPageViewModel.Pokemons = new ObservableCollection<PokemonViewModel>() { new PokemonViewModel {PokemonName = "Pikachu",Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png")},
                new PokemonViewModel { PokemonName = "Charizard",Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png"},
                new PokemonViewModel { PokemonName = "Squirtle",Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png")}};

            var orderedViewModel = pokemonPageViewModel.Pokemons.OrderBy(pokemon => pokemon.Name);
        }
        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pokemon = e.Item as PokemonViewModel;

            pokemonPageViewModel.SelectedPokemon = pokemon;
            

            //Detail = new NavigationPage(new PokemonPage(pokemonViewModel))
            //{
            //    BarBackgroundColor = Color.DeepSkyBlue
            //};
        }
    }
}
