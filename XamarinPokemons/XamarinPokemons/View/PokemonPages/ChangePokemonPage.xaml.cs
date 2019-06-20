using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPokemons.Models;
using XamarinPokemons.ViewModels;
using XamarinPokemons.ViewModels.Menu;
using XamarinPokemons.ViewModels.Pokemons;

namespace XamarinPokemons.View.PokemonPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePokemonPage : ContentPage
    {
        private Pokemon Pokemon { get; set; }
        private MenuItemViewModel MenuItem { get; set; }
        private int resultHeight;
        private int resultWeight;
        private bool canChange = true;
        private bool pokemon = true;
        public Command ChangeCommand => new Command( async () => await Change(), () => canChange);

        public ChangePokemonPage(PokemonPageViewModel pokemonPageViewModel)
        {
            InitializeComponent();
            this.Pokemon = pokemonPageViewModel.SelectedPokemon;
            BindingContext = this;
            Title = Pokemon.PokemonName;
            NameEntry.Text = Pokemon.Name;
            HeightEntry.Text = Pokemon.Height.ToString();
            WeightEntry.Text = Pokemon.Weight.ToString();

            canChange = false;
            ChangeCommand.ChangeCanExecute();
        }

        public ChangePokemonPage(MenuItemViewModel menuItemViewModel)
        {
            InitializeComponent();
            this.MenuItem = menuItemViewModel;
            BindingContext = this;
            Title = Pokemon.PokemonName;
            NameEntry.Text = Pokemon.Name;
            HeightEntry.Text = Pokemon.Height.ToString();
            WeightEntry.Text = Pokemon.Weight.ToString();

            canChange = false;
            pokemon = false;
            ChangeCommand.ChangeCanExecute();
        }

        private async Task Change()
        {
            if (pokemon)
            {
                Pokemon.Name = NameEntry.Text;
                Pokemon.Height = Int32.Parse(HeightEntry.Text);
                Pokemon.Weight = Int32.Parse(WeightEntry.Text);
                await Navigation.PopAsync();
            }
            else
            {
                //Get

                MenuItem.Name = NameEntry.Text;
                MenuItem.Height = Int32.Parse(HeightEntry.Text);
                MenuItem.Weight = Int32.Parse(WeightEntry.Text);
                await Navigation.PopAsync();
            }
        }

        private async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

  
}