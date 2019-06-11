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
using XamarinPokemons.ViewModels;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons
{
    [DesignTimeVisible(true)]
    public partial class MasterPage : ContentPage
    {
        public PokemonPageViewModel PokemonPageViewModel;
        public MasterPage()
        {
            InitializeComponent();
            L.Source = ImageSource.FromFile("Pokeball.png");
            var masterViewModel = new MasterViewModel();
            listDetail.ItemsSource = masterViewModel.pokemonPageViewModel.Pokemons.OrderBy(x => x.Name);
            BindingContext = masterViewModel;


        }
    }
}