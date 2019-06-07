using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public PokemonPage()
        {
            InitializeComponent();
            BindingContext = new PokemonsViewModel();
        
        }

        //public PokemonPage(PokemonsViewModel pokemonVM)
        //{
            
        //    this.BindingContext = pokemonVM;
        //    var bindingName = new Binding
        //    {
        //        Source = BindingContext,
        //        Path = "Name"
        //    };
        //    var bindingHeight = new Binding
        //    {
        //        Source = BindingContext,
        //        Path = "Height"
        //    };
        //    var bindingWeight = new Binding
        //    {
        //        Source = BindingContext,
        //        Path = "Weight"
        //    };

        //    Title = pokemonVM.SelectedPokemon.PokemonName;
        //    Name.SetBinding(Label.TextProperty, bindingName);
        //    Height.SetBinding(Label.TextProperty, bindingHeight);
        //    Weight.SetBinding(Label.TextProperty, bindingWeight);
        //}
    }
}