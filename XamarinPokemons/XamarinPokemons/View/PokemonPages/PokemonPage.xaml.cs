using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.PokemonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonPage : ContentPage
    {
        private PokemonViewModel pokemonViewModel;

        public PokemonPage()
        {

        }

        public PokemonPage(PokemonViewModel pokemonViewModel)
        {
            InitializeComponent();
            this.BindingContext = pokemonViewModel;
            this.pokemonViewModel = pokemonViewModel;
            var bindingName = new Binding
            {
                Source = pokemonViewModel,
                Path = "Name"
            };

            Title = pokemonViewModel.PokemonName;
            Name.SetBinding(Label.TextProperty, bindingName);

            Height.Text = pokemonViewModel.Height.ToString();
            Weight.Text = pokemonViewModel.Weight.ToString();

        }
    }
}