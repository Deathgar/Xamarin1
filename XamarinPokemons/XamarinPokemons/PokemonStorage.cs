using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XamarinPokemons.Models;

namespace XamarinPokemons
{
    public class PokemonStorage
    {
        public ObservableCollection<Pokemon> pokemons { get; set; }

        public ObservableCollection<Pokemon> FillPokemons()
        {
            var PersonalFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            pokemons = new ObservableCollection<Pokemon>() { new Pokemon {PokemonName = "Pikachu",Name = "Pika", Height = 30, Weight = 12, ImageSource = ImageSource.FromFile("Pikachu.png")},
                new Pokemon { PokemonName = "Charizard",Name = "Char", Height = 170, Weight = 90, ImageSource = "Charizard.png"},
                new Pokemon { PokemonName = "Squirtle",Name = "Squirtle", Height = 50, Weight = 9, ImageSource = ImageSource.FromFile("Squirtle.png")} };

            return pokemons;
        }
    }
}
