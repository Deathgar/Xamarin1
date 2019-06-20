using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels.Menu;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.PokemonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonPage : ContentPage
    {
        public PokemonPage()
        {
            InitializeComponent();
            BindingContext = new PokemonPageViewModel();
        }

        public PokemonPage(PokemonPageViewModel pokemonPageVM)
        {
            InitializeComponent();
            this.BindingContext = pokemonPageVM;
            var bindingName = new Binding
            {
                Source = pokemonPageVM.SelectedPokemon,
                Path = "Name"
            };
            var bindingHeight = new Binding
            {
                Source = pokemonPageVM.SelectedPokemon,
                Path = "Height"
            };
            var bindingWeight = new Binding
            {
                Source = pokemonPageVM.SelectedPokemon,
                Path = "Weight"
            };

            Title = pokemonPageVM.SelectedPokemon.PokemonName;
            NameLabel.SetBinding(Label.TextProperty, bindingName);
            HeightLabel.SetBinding(Label.TextProperty, bindingHeight);
            WeightLabel.SetBinding(Label.TextProperty, bindingWeight);
        }

        public PokemonPage(MenuItemViewModel menuItemVM)
        {
            InitializeComponent();
            this.BindingContext = menuItemVM; ;
            var bindingName = new Binding
            {
                Source = menuItemVM,
                Path = "Name"
            };
            var bindingHeight = new Binding
            {
                Source = menuItemVM,
                Path = "Height"
            };
            var bindingWeight = new Binding
            {
                Source = menuItemVM,
                Path = "Weight"
            };

            Title = menuItemVM.PokemonName;
            NameLabel.SetBinding(Label.TextProperty, bindingName);
            HeightLabel.SetBinding(Label.TextProperty, bindingHeight);
            WeightLabel.SetBinding(Label.TextProperty, bindingWeight);
        }


    }
}